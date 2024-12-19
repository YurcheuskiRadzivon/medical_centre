using HospitalProject.Business.Entities;
using HospitalProject.Business.Entities.Personnel;
using System;
using System.Linq;
using System.Windows.Forms;

public partial class EditNurseForm : Form
{
    private Hospital hospital;
    private Nurse nurse;

    public event EventHandler NurseUpdated;

    public EditNurseForm(Hospital hospital, Nurse nurse)
    {
        this.hospital = hospital;
        this.nurse = nurse;
        InitializeComponent();
        LoadDepartments();
        LoadNurseDetails();
    }

    private void LoadDepartments()
    {
        cbDepartment.Items.AddRange(hospital.Departments.Select(d => d.Name).ToArray());
    }

    private void LoadNurseDetails()
    {
        txtFirstName.Text = nurse.FirstName;
        txtLastName.Text = nurse.LastName;
        txtMiddleName.Text = nurse.MiddleName;
        var department = hospital.Departments.FirstOrDefault(d => d.Id == nurse.DepartmentId);
        if (department != null)
        {
            cbDepartment.SelectedItem = department.Name;
        }
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        var department = hospital.Departments.FirstOrDefault(d => d.Name == cbDepartment.SelectedItem.ToString());
        nurse.FirstName = txtFirstName.Text;
        nurse.LastName = txtLastName.Text;
        nurse.MiddleName = txtMiddleName.Text;
        nurse.DepartmentId = department?.Id ?? 0;

        NurseUpdated?.Invoke(this, EventArgs.Empty);
        this.Close();
    }
}
