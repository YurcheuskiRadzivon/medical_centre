using HospitalProject.Business.Entities;
using HospitalProject.Business.Entities.Personnel;
using System;
using System.Linq;
using System.Windows.Forms;

public partial class EditDoctorForm : Form
{
    private Hospital hospital;
    private Doctor doctor;

    public event EventHandler DoctorUpdated;

    public EditDoctorForm(Hospital hospital, Doctor doctor)
    {
        this.hospital = hospital;
        this.doctor = doctor;
        InitializeComponent();
        LoadDepartments();
        LoadDoctorDetails();
    }

    private void LoadDepartments()
    {
        cbDepartment.Items.AddRange(hospital.Departments.Select(d => d.Name).ToArray());
    }

    private void LoadDoctorDetails()
    {
        txtFirstName.Text = doctor.FirstName;
        txtLastName.Text = doctor.LastName;
        txtMiddleName.Text = doctor.MiddleName;
        cbSpecialty.Text = doctor.Specialty;
        var department = hospital.Departments.FirstOrDefault(d => d.Id == doctor.DepartmentId);
        if (department != null)
        {
            cbDepartment.SelectedItem = department.Name;
        }
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        var department = hospital.Departments.FirstOrDefault(d => d.Name == cbDepartment.SelectedItem.ToString());
        doctor.FirstName = txtFirstName.Text;
        doctor.LastName = txtLastName.Text;
        doctor.MiddleName = txtMiddleName.Text;
        doctor.Specialty = cbSpecialty.Text == "Другое" ? txtSpecialty.Text : cbSpecialty.Text;
        doctor.DepartmentId = department?.Id ?? 0;

        DoctorUpdated?.Invoke(this, EventArgs.Empty);
        this.Close();
    }
}
