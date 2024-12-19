using HospitalProject.Business.Entities;
using HospitalProject.Business.Entities.Departments;
using System;
using System.Windows.Forms;

public partial class ManagerDepartamentForm : Form
{
    private Hospital hospital;

    public ManagerDepartamentForm(Hospital hospital)
    {
        this.hospital = hospital;
        InitializeComponent();
    }

    private void ManagerDepartamentForm_Load(object sender, EventArgs e)
    {
        RefreshDepartmentList();
    }

    private void RefreshDepartmentList()
    {
        lstDepartments.Items.Clear();
        foreach (var department in hospital.Departments)
        {
            var listViewItem = new ListViewItem(department.Name);
            listViewItem.SubItems.Add(department.Id.ToString());
            listViewItem.SubItems.Add(department.Doctors.Count.ToString());
            listViewItem.SubItems.Add(department.Nurses.Count.ToString());
            listViewItem.SubItems.Add(department.Patients.Count.ToString());
            listViewItem.SubItems.Add(department.MedicationTypes.Count.ToString());
            listViewItem.SubItems.Add(department.DiagnosticTypes.Count.ToString());
            listViewItem.SubItems.Add(department.PreventiveTypes.Count.ToString());
            listViewItem.Tag = department;
            lstDepartments.Items.Add(listViewItem);
        }
    }

    private void BtnBack_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void BtnAddDepartment_Click(object sender, EventArgs e)
    {
        var addDepartmentForm = new AddDepartmentForm(hospital);
        addDepartmentForm.DepartmentAdded += (s, ev) => RefreshDepartmentList();
        addDepartmentForm.Show();
    }

    private void LstDepartments_ItemActivate(object sender, EventArgs e)
    {
        if (lstDepartments.SelectedItems.Count > 0)
        {
            var selectedDepartment = (Department)lstDepartments.SelectedItems[0].Tag;
            var editDepartmentForm = new EditDepartmentForm(hospital, selectedDepartment);
            editDepartmentForm.DepartmentUpdated += (s, ev) => RefreshDepartmentList();
            editDepartmentForm.Show();
        }
    }

    private void BtnDeleteDepartment_Click(object sender, EventArgs e)
    {
        if (lstDepartments.SelectedItems.Count > 0)
        {
            var selectedDepartment = (Department)lstDepartments.SelectedItems[0].Tag;
            hospital.Departments.Remove(selectedDepartment);
            RefreshDepartmentList();
        }
    }
}
