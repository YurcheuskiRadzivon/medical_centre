using HospitalProject.Business.Entities;
using HospitalProject.Business.Entities.Personnel;
using System;
using System.Linq;
using System.Windows.Forms;

public partial class LoginNurseForm : Form
{
    private Hospital hospital;

    public event EventHandler<Nurse> NurseLoggedIn;

    public LoginNurseForm(Hospital hospital)
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
        LoadNurses();
    }

    private void LoadNurses()
    {
        cbNurse.Items.Clear();
        var selectedDepartment = hospital.Departments.FirstOrDefault(d => d.Name == cbDepartment.SelectedItem.ToString());
        if (selectedDepartment != null)
        {
            var nurses = hospital.Nurses.Where(nurse => nurse.DepartmentId == selectedDepartment.Id);
            cbNurse.Items.AddRange(nurses.Select(nurse => $"{nurse.Id}: {nurse.FirstName} {nurse.LastName}").ToArray());
        }
    }

    private void BtnLogin_Click(object sender, EventArgs e)
    {
        var selectedNurseId = int.Parse(cbNurse.SelectedItem.ToString().Split(':')[0]);
        var nurse = hospital.Nurses.FirstOrDefault(n => n.Id == selectedNurseId);

        if (nurse == null)
        {
            MessageBox.Show("Такой медсестры нет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            NurseLoggedIn?.Invoke(this, nurse);
            this.Close();
        }
    }
}
