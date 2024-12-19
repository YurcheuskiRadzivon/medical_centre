using HospitalProject.Business.Entities.Appointments.SpecificAppointmentTypes;
using System;
using System.Windows.Forms;

public partial class AddPreventiveForm : Form
{
    public event EventHandler<PreventiveAppointment> PreventiveAdded;

    public AddPreventiveForm()
    {
        InitializeComponent();
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        var newPreventive = new PreventiveAppointment
        {
            Name = txtPreventiveName.Text,
            PreventiveMeasure = txtPreventiveMeasure.Text
        };

        PreventiveAdded?.Invoke(this, newPreventive);
        this.Close();
    }
}
