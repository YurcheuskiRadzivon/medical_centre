﻿using HospitalProject.Business.Entities;
using HospitalProject.Business.Entities.Appointments.SpecificAppointmentTypes;
using HospitalProject.Business.Entities.Departments;

using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class EditDepartmentForm : Form
{
    private readonly IDepartmentService _departmentService;
    private readonly Hospital _hospital;
    private readonly Department _department;

    public event EventHandler DepartmentUpdated;

    public EditDepartmentForm(Hospital hospital, Department department)
    {
        _hospital = hospital;
        _department = department;
        _departmentService = new DepartmentService(hospital);
        InitializeComponent();
    }

    private void EditDepartmentForm_Load(object sender, EventArgs e)
    {
        txtDepartmentName.Text = _department.Name;
        lvMedicationTypes.Items.AddRange(_department.MedicationTypes.Select(m => new ListViewItem(new[] { m.Name, m.Quantity.ToString(), m.Dosage.ToString() })).ToArray());
        lvDiagnosticTypes.Items.AddRange(_department.DiagnosticTypes.Select(d => new ListViewItem(new[] { d.Name, d.DiagnosticTool })).ToArray());
        lvPreventiveTypes.Items.AddRange(_department.PreventiveTypes.Select(p => new ListViewItem(new[] { p.Name, p.PreventiveMeasure })).ToArray());
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        _department.Name = txtDepartmentName.Text;
        _department.MedicationTypes = GetMedicationAppointments();
        _department.DiagnosticTypes = GetDiagnosticAppointments();
        _department.PreventiveTypes = GetPreventiveAppointments();

        _departmentService.UpdateDepartment(_department);
        DepartmentUpdated?.Invoke(this, EventArgs.Empty);
        this.Close();
    }

    private List<MedicationAppointment> GetMedicationAppointments()
    {
        var medicationAppointments = new List<MedicationAppointment>();
        foreach (ListViewItem item in lvMedicationTypes.Items)
        {
            var appointment = new MedicationAppointment
            {
                Name = item.SubItems[0].Text,
                Quantity = int.Parse(item.SubItems[1].Text),
                Dosage = int.Parse(item.SubItems[2].Text)
            };
            medicationAppointments.Add(appointment);
        }
        return medicationAppointments;
    }

    private List<DiagnosticAppointment> GetDiagnosticAppointments()
    {
        var diagnosticAppointments = new List<DiagnosticAppointment>();
        foreach (ListViewItem item in lvDiagnosticTypes.Items)
        {
            var appointment = new DiagnosticAppointment
            {
                Name = item.SubItems[0].Text,
                DiagnosticTool = item.SubItems[1].Text
            };
            diagnosticAppointments.Add(appointment);
        }
        return diagnosticAppointments;
    }

    private List<PreventiveAppointment> GetPreventiveAppointments()
    {
        var preventiveAppointments = new List<PreventiveAppointment>();
        foreach (ListViewItem item in lvPreventiveTypes.Items)
        {
            var appointment = new PreventiveAppointment
            {
                Name = item.SubItems[0].Text,
                PreventiveMeasure = item.SubItems[1].Text
            };
            preventiveAppointments.Add(appointment);
        }
        return preventiveAppointments;
    }

    private void BtnAddMedication_Click(object sender, EventArgs e)
    {
        var addMedicationForm = new AddMedicationForm();
        addMedicationForm.MedicationAdded += (s, med) =>
        {
            var item = new ListViewItem(med.Name);
            item.SubItems.Add(med.Quantity.ToString());
            item.SubItems.Add(med.Dosage.ToString());
            lvMedicationTypes.Items.Add(item);
        };
        addMedicationForm.Show();
    }

    private void BtnEditMedication_Click(object sender, EventArgs e)
    {
        if (lvMedicationTypes.SelectedItems.Count > 0)
        {
            var selectedItem = lvMedicationTypes.SelectedItems[0];
            var editMedicationForm = new EditMedicationForm(selectedItem);
            editMedicationForm.MedicationUpdated += (s, med) =>
            {
                selectedItem.SubItems[0].Text = med.Name;
                selectedItem.SubItems[1].Text = med.Quantity.ToString();
                selectedItem.SubItems[2].Text = med.Dosage.ToString();
            };
            editMedicationForm.Show();
        }
    }

    private void BtnDeleteMedication_Click(object sender, EventArgs e)
    {
        if (lvMedicationTypes.SelectedItems.Count > 0)
        {
            lvMedicationTypes.Items.Remove(lvMedicationTypes.SelectedItems[0]);
        }
    }

    private void BtnAddDiagnostic_Click(object sender, EventArgs e)
    {
        var addDiagnosticForm = new AddDiagnosticForm();
        addDiagnosticForm.DiagnosticAdded += (s, diag) =>
        {
            var item = new ListViewItem(diag.Name);
            item.SubItems.Add(diag.DiagnosticTool);
            lvDiagnosticTypes.Items.Add(item);
        };
        addDiagnosticForm.Show();
    }

    private void BtnEditDiagnostic_Click(object sender, EventArgs e)
    {
        if (lvDiagnosticTypes.SelectedItems.Count > 0)
        {
            var selectedItem = lvDiagnosticTypes.SelectedItems[0];
            var editDiagnosticForm = new EditDiagnosticForm(selectedItem);
            editDiagnosticForm.DiagnosticUpdated += (s, diag) =>
            {
                selectedItem.SubItems[0].Text = diag.Name;
                selectedItem.SubItems[1].Text = diag.DiagnosticTool;
            };
            editDiagnosticForm.Show();
        }
    }

    private void BtnDeleteDiagnostic_Click(object sender, EventArgs e)
    {
        if (lvDiagnosticTypes.SelectedItems.Count > 0)
        {
            lvDiagnosticTypes.Items.Remove(lvDiagnosticTypes.SelectedItems[0]);
        }
    }

    private void BtnAddPreventive_Click(object sender, EventArgs e)
    {
        var addPreventiveForm = new AddPreventiveForm();
        addPreventiveForm.PreventiveAdded += (s, prev) =>
        {
            var item = new ListViewItem(prev.Name);
            item.SubItems.Add(prev.PreventiveMeasure);
            lvPreventiveTypes.Items.Add(item);
        };
        addPreventiveForm.Show();
    }

    private void BtnEditPreventive_Click(object sender, EventArgs e)
    {
        if (lvPreventiveTypes.SelectedItems.Count > 0)
        {
            var selectedItem = lvPreventiveTypes.SelectedItems[0];
            var editPreventiveForm = new EditPreventiveForm(selectedItem);
            editPreventiveForm.PreventiveUpdated += (s, prev) =>
            {
                selectedItem.SubItems[0].Text = prev.Name;
                selectedItem.SubItems[1].Text = prev.PreventiveMeasure;
            };
            editPreventiveForm.Show();
        }
    }

    private void BtnDeletePreventive_Click(object sender, EventArgs e)
    {
        if (lvPreventiveTypes.SelectedItems.Count > 0)
        {
            lvPreventiveTypes.Items.Remove(lvPreventiveTypes.SelectedItems[0]);
        }
    }
}