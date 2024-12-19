using HospitalProject.Business.Entities;
using HospitalProject.Business.Entities.Personnel;

using System;
using System.Linq;
using System.Windows.Forms;

public partial class AddDoctorForm : Form
{
    private readonly IDoctorService _doctorService;
    private readonly IDepartmentService _departmentService;

    public event EventHandler DoctorAdded;

    public AddDoctorForm(Hospital hospital)
    {
        _doctorService = new DoctorService(hospital);
        _departmentService = new DepartmentService(hospital);
        InitializeComponent();
        LoadDepartments();
    }

    private void LoadDepartments()
    {
        var departments = _departmentService.GetAllDepartments().ToList();
        cbDepartment.Items.AddRange(departments.Select(d => d.Name).ToArray());
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        var department = _departmentService.GetAllDepartments().FirstOrDefault(d => d.Name == cbDepartment.SelectedItem.ToString());
        var newDoctor = new Doctor
        {
            Id = 0,
            FirstName = txtFirstName.Text,
            LastName = txtLastName.Text,
            MiddleName = txtMiddleName.Text,
            Specialty = cbSpecialty.Text == "Другое" ? txtSpecialty.Text : cbSpecialty.Text,
            DepartmentId = department?.Id ?? 0
        };

        _doctorService.CreateDoctor(newDoctor);
        DoctorAdded?.Invoke(this, EventArgs.Empty);
        this.Close();
    }
}
