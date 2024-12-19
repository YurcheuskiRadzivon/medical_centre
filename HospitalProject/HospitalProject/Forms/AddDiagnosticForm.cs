using HospitalProject.Business.Entities.Appointments.SpecificAppointmentTypes;
using System;
using System.Windows.Forms;

public partial class AddDiagnosticForm : Form
{
    public event EventHandler<DiagnosticAppointment> DiagnosticAdded;

    public AddDiagnosticForm()
    {
        InitializeComponent();
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        var newDiagnostic = new DiagnosticAppointment
        {
            Name = txtDiagnosticName.Text,
            DiagnosticTool = txtDiagnosticTool.Text
        };

        DiagnosticAdded?.Invoke(this, newDiagnostic);
        this.Close();
    }
}
