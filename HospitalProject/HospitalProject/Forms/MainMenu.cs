using HospitalProject.Business.Entities;
using System;
using System.Windows.Forms;

public partial class MainMenu : Form
{
    private Hospital hospital;

    public MainMenu(Hospital hospital)
    {
        this.hospital = hospital;
        InitializeComponent();
    }

    private void BtnHospitalManager_Click(object sender, EventArgs e)
    {
        var hospitalManagerForm = new HospitalManagerForm(hospital);
        hospitalManagerForm.Show();
    }

    private void BtnDutyDepartment_Click(object sender, EventArgs e)
    {
        var dutyDepartmentForm = new DutyDepartmentForm(hospital);
        dutyDepartmentForm.Show();
    }

    private void BtnPatientManagement_Click(object sender, EventArgs e)
    {
        var patientManagementForm = new ManagePatientsForm(hospital);
        patientManagementForm.Show();
    }

    private void BtnExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
    private void MainMenu_Load(object sender, EventArgs e)
    {

    }
}
