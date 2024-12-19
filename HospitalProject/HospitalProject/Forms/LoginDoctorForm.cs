using HospitalProject.Business.Entities;
using HospitalProject.Business.Entities.Personnel;
using System;
using System.Linq;
using System.Windows.Forms;

public partial class LoginDoctorForm : Form
{
    private Hospital hospital;

    public event EventHandler<Doctor> DoctorLoggedIn;

    public LoginDoctorForm(Hospital hospital)
    {
        this.hospital = hospital;
        InitializeComponent();
        LoadDepartments();
    }

    private void LoadDepartments()
    {
        cbDepartment.Items.AddRange(hospital.Departments.Select(d => d.Name).ToArray());
    }

    private void CbDepartment_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadDoctors();
    }

    private void LoadDoctors()
    {
        cbDoctor.Items.Clear();
        var selectedDepartment = hospital.Departments.FirstOrDefault(d => d.Name == cbDepartment.SelectedItem.ToString());
        if (selectedDepartment != null)
        {
            var doctors = hospital.Doctors.Where(doc => doc.DepartmentId == selectedDepartment.Id);
            cbDoctor.Items.AddRange(doctors.Select(doc => $"{doc.Id}: {doc.FirstName} {doc.LastName} - {doc.Specialty}").ToArray());
        }
    }

    private void BtnLogin_Click(object sender, EventArgs e)
    {
        var selectedDoctorId = int.Parse(cbDoctor.SelectedItem.ToString().Split(':')[0]);
        var doctor = hospital.Doctors.FirstOrDefault(d => d.Id == selectedDoctorId);

        if (doctor == null)
        {
            MessageBox.Show("Такого врача нет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            DoctorLoggedIn?.Invoke(this, doctor);
            this.Close();
        }
    }
}
