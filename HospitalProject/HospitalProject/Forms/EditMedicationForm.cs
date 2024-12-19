using HospitalProject.Business.Entities.Appointments.SpecificAppointmentTypes;
using System;
using System.Windows.Forms;

public partial class EditMedicationForm : Form
{
    private ListViewItem item;

    public event EventHandler<MedicationAppointment> MedicationUpdated;

    public EditMedicationForm(ListViewItem item)
    {
        this.item = item;
        InitializeComponent();
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        var updatedMedication = new MedicationAppointment
        {
            Name = txtMedicationName.Text,
            Quantity = int.Parse(txtQuantity.Text),
            Dosage = int.Parse(txtDosage.Text)
        };

        MedicationUpdated?.Invoke(this, updatedMedication);
        this.Close();
    }
}
