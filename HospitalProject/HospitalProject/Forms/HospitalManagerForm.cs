using HospitalProject.Business.Entities;
using System;
using System.Windows.Forms;

public partial class HospitalManagerForm : Form
{
    private Hospital hospital;

    public HospitalManagerForm(Hospital hospital)
    {
        this.hospital = hospital;
        InitializeComponent();
    }

    private void BtnManagerDepartament_Click(object sender, EventArgs e)
    {
        var managerDepartamentForm = new ManagerDepartamentForm(hospital);
        managerDepartamentForm.Show();
    }

    private void BtnManagerPersonnel_Click(object sender, EventArgs e)
    {
        var managerPersonnelForm = new ManagerPersonnelForm(hospital);
        managerPersonnelForm.Show();
    }

    private void BtnBack_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    private void HospitalManagerForm_Load(object sender, EventArgs e)
    {

    }
}
