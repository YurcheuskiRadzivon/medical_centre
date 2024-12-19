using HospitalProject.Business.Entities.Appointments.SpecificAppointmentTypes;
using System;
using System.Windows.Forms;

public partial class EditPreventiveForm : Form
{
    private ListViewItem item;

    public event EventHandler<PreventiveAppointment> PreventiveUpdated;

    public EditPreventiveForm(ListViewItem item)
    {
        this.item = item;
        InitializeComponent();
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        var updatedPreventive = new PreventiveAppointment
        {
            Name = txtPreventiveName.Text,
            PreventiveMeasure = txtPreventiveMeasure.Text
        };

        PreventiveUpdated?.Invoke(this, updatedPreventive);
        this.Close();
    }
}
