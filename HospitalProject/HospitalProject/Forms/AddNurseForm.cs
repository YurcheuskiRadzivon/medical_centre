using HospitalProject.Business.Entities;
using HospitalProject.Business.Entities.Personnel;

using System;
using System.Linq;
using System.Windows.Forms;

public partial class AddNurseForm : Form
{
    private readonly INurseService _nurseService;
    private readonly IDepartmentService _departmentService;

    public event EventHandler NurseAdded;

    public AddNurseForm(Hospital hospital)
    {
        _nurseService = new NurseService(hospital);
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
        var newNurse = new Nurse
        {
            Id = 0,
            FirstName = txtFirstName.Text,
            LastName = txtLastName.Text,
            MiddleName = txtMiddleName.Text,
            DepartmentId = department?.Id ?? 0
        };

        _nurseService.CreateNurse(newNurse);
        NurseAdded?.Invoke(this, EventArgs.Empty);
        this.Close();
    }
}
