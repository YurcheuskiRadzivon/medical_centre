using HospitalProject.Business.Entities.Appointments.SpecificAppointmentTypes;
using System;
using System.Windows.Forms;

public partial class AddMedicationForm : Form
{
    public event EventHandler<MedicationAppointment> MedicationAdded;

    public AddMedicationForm()
    {
        InitializeComponent();
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        var newMedication = new MedicationAppointment
        {
            Name = txtMedicationName.Text,
            Quantity = int.Parse(txtQuantity.Text),
            Dosage = int.Parse(txtDosage.Text)
        };

        MedicationAdded?.Invoke(this, newMedication);
        this.Close();
    }
}
