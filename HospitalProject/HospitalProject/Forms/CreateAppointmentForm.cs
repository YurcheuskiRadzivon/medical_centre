using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using HospitalProject.Business.Entities.Appointments;
using HospitalProject.Business.Entities.Appointments.SpecificAppointmentTypes;
using HospitalProject.Business.Entities.Patients;
using HospitalProject.Business.Entities;


public partial class CreateAppointmentForm : Form
{
    private readonly IAppointmentService _appointmentService;
    private readonly IPatientService _patientService;
    private readonly IDoctorService _doctorService;
    private readonly INurseService _nurseService;
    private readonly Patient _patient;

    public event EventHandler AppointmentCreated;

    public CreateAppointmentForm(Hospital hospital, Patient patient)
    {
        _appointmentService = new AppointmentService(hospital);
        _patientService = new PatientService(hospital);
        _doctorService = new DoctorService(hospital);
        _nurseService = new NurseService(hospital);
        _patient = patient;

        InitializeComponent();
        LoadAppointmentTypes();
        LoadPersonnel();
    }

    private void LoadAppointmentTypes()
    {
        var appointmentTypes = new List<TypeAppointment>
        {
            new DiagnosticAppointment(),
            new MedicationAppointment(),
            new PreventiveAppointment()
        };

        cbAppointmentType.Items.AddRange(appointmentTypes.ToArray());
    }

    private void LoadPersonnel()
    {
        cbPersonnel.Items.Clear();

        if (cbAppointmentType.SelectedItem is MedicationAppointment)
        {
            var nurses = _nurseService.GetAllNurses()
                .Where(nurse => nurse.DepartmentId == _patient.DepartmentId)
                .Select(nurse => new { nurse.Id, Name = $"{nurse.FirstName} {nurse.LastName} - Медсестра" })
                .ToList();

            cbPersonnel.Items.AddRange(nurses.ToArray());
        }
        else
        {
            var doctors = _doctorService.GetAllDoctors()
                .Where(doc => doc.DepartmentId == _patient.DepartmentId && doc.Specialty != "Лечащий врач")
                .Select(doc => new { doc.Id, Name = $"{doc.FirstName} {doc.LastName} - {doc.Specialty}" })
                .ToList();

            cbPersonnel.Items.AddRange(doctors.ToArray());
        }
    }

    private void CbAppointmentType_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadPersonnel();
    }

    private void BtnCreate_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtDescription.Text) ||
            cbAppointmentType.SelectedItem == null ||
            cbPersonnel.SelectedItem == null)
        {
            MessageBox.Show("Все поля должны быть заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        dynamic selectedPersonnel = cbPersonnel.SelectedItem;
        TypeAppointment selectedAppointmentType = (TypeAppointment)cbAppointmentType.SelectedItem;

        var newAppointment = new Appointment
        {
            Id = _appointmentService.GetAllAppointments().Count() + 1,
            Description = txtDescription.Text,
            PatientId = _patient.Id,
            PersonnelId = selectedPersonnel.Id,
            Status = "Назначено",
            AppointmentType = selectedAppointmentType,
            AppointmentTime = DateTime.Now
        };

        _appointmentService.CreateAppointment(newAppointment);

        
        var updatedPatient = _patientService.GetPatientById(_patient.Id);
        updatedPatient.MedicalRecord.Appointments.Add(newAppointment);

        _patientService.UpdatePatient(updatedPatient);

        AppointmentCreated?.Invoke(this, EventArgs.Empty);
        this.Close();
    }
}
