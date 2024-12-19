using HospitalProject.Business.Entities.Appointments.SpecificAppointmentTypes;
using System;
using System.Windows.Forms;

public partial class EditDiagnosticForm : Form
{
    private ListViewItem item;

    public event EventHandler<DiagnosticAppointment> DiagnosticUpdated;

    public EditDiagnosticForm(ListViewItem item)
    {
        this.item = item;
        InitializeComponent();
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        var updatedDiagnostic = new DiagnosticAppointment
        {
            Name = txtDiagnosticName.Text,
            DiagnosticTool = txtDiagnosticTool.Text
        };

        DiagnosticUpdated?.Invoke(this, updatedDiagnostic);
        this.Close();
    }
}
