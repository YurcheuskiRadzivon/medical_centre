using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using HospitalProject.Business.Entities.Appointments;
using HospitalProject.Business.Entities.Patients;
using HospitalProject.Business.Entities.MedicalRecords;
using HospitalProject.Business.Entities;


public partial class DutyDepartmentForm : Form
{
    private readonly IDepartmentService _departmentService;
    private readonly IDoctorService _doctorService;
    private readonly IPatientService _patientService;
    private readonly Hospital _hospital;

    public event EventHandler PatientAdded;

    public DutyDepartmentForm(Hospital hospital)
    {
        _departmentService = new DepartmentService(hospital);
        _doctorService = new DoctorService(hospital);
        _patientService = new PatientService(hospital);
        _hospital = hospital;

        InitializeComponent();
        LoadDepartments();
    }

    private void LoadDepartments()
    {
        var departments = _departmentService.GetAllDepartments().ToList();
        cbDepartment.Items.AddRange(departments.Select(d => d.Name).ToArray());
    }

    private void CbDepartment_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadDutyDoctors();
    }

    private void LoadDutyDoctors()
    {
        cbDutyDoctor.Items.Clear();
        var selectedDepartment = _departmentService.GetAllDepartments().FirstOrDefault(d => d.Name == cbDepartment.SelectedItem.ToString());
        if (selectedDepartment != null)
        {
            var dutyDoctors = _doctorService.GetAllDoctors()
                .Where(doc => doc.DepartmentId == selectedDepartment.Id && doc.Specialty == "Лечащий врач")
                .Select(doc => $"{doc.Id}: {doc.FirstName} {doc.LastName}")
                .ToArray();

            cbDutyDoctor.Items.AddRange(dutyDoctors);
        }
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
            string.IsNullOrWhiteSpace(txtLastName.Text) ||
            string.IsNullOrWhiteSpace(txtMiddleName.Text) ||
            string.IsNullOrWhiteSpace(txtDiagnosis.Text) ||
            cbDepartment.SelectedItem == null ||
            cbDutyDoctor.SelectedItem == null)
        {
            MessageBox.Show("Все поля должны быть заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var department = _departmentService.GetAllDepartments().FirstOrDefault(d => d.Name == cbDepartment.SelectedItem.ToString());
        var selectedDoctorId = int.Parse(cbDutyDoctor.SelectedItem.ToString().Split(':')[0]);

        var newPatient = new Patient
        {
            Id = 0,
            FirstName = txtFirstName.Text,
            LastName = txtLastName.Text,
            MiddleName = txtMiddleName.Text,
            DepartmentId = department?.Id ?? 0,
            diagnosis = txtDiagnosis.Text,
            MedicalRecord = new MedicalRecord
            {
                PatientId = _patientService.GetAllPatients().Count() + 1,
                Appointments = new List<Appointment>()
            },
            PersonId = selectedDoctorId
        };

        _patientService.CreatePatient(newPatient);
        PatientAdded?.Invoke(this, EventArgs.Empty);
        this.Close();
    }
}
