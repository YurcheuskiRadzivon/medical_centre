using HospitalProject.Business.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

public partial class ManagerPersonnelForm : Form
{
    private Hospital hospital;

    public ManagerPersonnelForm(Hospital hospital)
    {
        this.hospital = hospital;
        InitializeComponent();
    }

    private void ManagerPersonnelForm_Load(object sender, EventArgs e)
    {
        RefreshPersonnelLists();
    }

    private void RefreshPersonnelLists()
    {
        lvDoctors.Items.Clear();
        lvNurses.Items.Clear();

        foreach (var doctor in hospital.Doctors)
        {
            var listItem = new ListViewItem(new[] {
                doctor.Id.ToString(),
                doctor.LastName,
                doctor.FirstName,
                doctor.MiddleName,
                doctor.Specialty,
                doctor.DepartmentId.ToString()
            });
            lvDoctors.Items.Add(listItem);
        }

        foreach (var nurse in hospital.Nurses)
        {
            var listItem = new ListViewItem(new[] {
                nurse.Id.ToString(),
                nurse.LastName,
                nurse.FirstName,
                nurse.MiddleName,
                nurse.DepartmentId.ToString()
            });
            lvNurses.Items.Add(listItem);
        }
    }

    private void BtnAddDoctor_Click(object sender, EventArgs e)
    {
        var addDoctorForm = new AddDoctorForm(hospital);
        addDoctorForm.DoctorAdded += (s, ev) => RefreshPersonnelLists();
        addDoctorForm.Show();
    }

    private void BtnAddNurse_Click(object sender, EventArgs e)
    {
        var addNurseForm = new AddNurseForm(hospital);
        addNurseForm.NurseAdded += (s, ev) => RefreshPersonnelLists();
        addNurseForm.Show();
    }

    private void LvDoctors_ItemActivate(object sender, EventArgs e)
    {
        if (lvDoctors.SelectedItems.Count > 0)
        {
            var selectedDoctor = hospital.Doctors.FirstOrDefault(d => d.Id == int.Parse(lvDoctors.SelectedItems[0].SubItems[0].Text));
            var editDoctorForm = new EditDoctorForm(hospital, selectedDoctor);
            editDoctorForm.DoctorUpdated += (s, ev) => RefreshPersonnelLists();
            editDoctorForm.Show();
        }
    }

    private void LvNurses_ItemActivate(object sender, EventArgs e)
    {
        if (lvNurses.SelectedItems.Count > 0)
        {
            var selectedNurse = hospital.Nurses.FirstOrDefault(n => n.Id == int.Parse(lvNurses.SelectedItems[0].SubItems[0].Text));
            var editNurseForm = new EditNurseForm(hospital, selectedNurse);
            editNurseForm.NurseUpdated += (s, ev) => RefreshPersonnelLists();
            editNurseForm.Show();
        }
    }

    private void BtnDeleteDoctor_Click(object sender, EventArgs e)
    {
        if (lvDoctors.SelectedItems.Count > 0)
        {
            var selectedDoctor = hospital.Doctors.FirstOrDefault(d => d.Id == int.Parse(lvDoctors.SelectedItems[0].SubItems[0].Text));
            hospital.Doctors.Remove(selectedDoctor);
            RefreshPersonnelLists();
        }
    }

    private void BtnDeleteNurse_Click(object sender, EventArgs e)
    {
        if (lvNurses.SelectedItems.Count > 0)
        {
            var selectedNurse = hospital.Nurses.FirstOrDefault(n => n.Id == int.Parse(lvNurses.SelectedItems[0].SubItems[0].Text));
            hospital.Nurses.Remove(selectedNurse);
            RefreshPersonnelLists();
        }
    }

    private void BtnBack_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
