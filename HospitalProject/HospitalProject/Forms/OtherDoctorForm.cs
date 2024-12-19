using System;
using System.Linq;
using System.Windows.Forms;
using HospitalProject.Business.Entities;
using HospitalProject.Business.Entities.Personnel;
using HospitalProject.Business.Entities.Appointments;


public partial class OtherDoctorForm : Form
{
    private Hospital hospital;
    private Doctor doctor;

    public OtherDoctorForm(Hospital hospital, Doctor doctor)
    {
        this.hospital = hospital;
        this.doctor = doctor;
        InitializeComponent();
        LoadAppointments();
    }

    private void LoadAppointments()
    {
        lvAppointments.Items.Clear(); // Очистить список перед добавлением новых элементов

        var appointments = hospital.Patients
            .SelectMany(p => p.MedicalRecord.Appointments)
            .Where(a => a.PersonnelId == doctor.Id && a.Status == "Назначено")
            .ToList();

        foreach (var appointment in appointments)
        {
            var listItem = new ListViewItem(new[] {
                appointment.Id.ToString(),
                appointment.Description,
                appointment.AppointmentType.GetType().Name,
                appointment.AppointmentTime.ToString("g")
            });
            lvAppointments.Items.Add(listItem);
        }
    }

    private void BtnCompleteAppointment_Click(object sender, EventArgs e)
    {
        if (lvAppointments.SelectedItems.Count > 0)
        {
            var selectedAppointmentId = int.Parse(lvAppointments.SelectedItems[0].SubItems[0].Text);
            var selectedAppointment = hospital.Patients
                .SelectMany(p => p.MedicalRecord.Appointments)
                .First(a => a.Id == selectedAppointmentId);

            selectedAppointment.Status = "Выполнено";

            var patient = hospital.Patients.First(p => p.Id == selectedAppointment.PatientId);
            patient.MedicalRecord.Appointments.Add(new Appointment
            {
                Id = hospital.IdSaving.AppointmentId++,
                Description = $"Выполнено: {selectedAppointment.Description}",
                PatientId = selectedAppointment.PatientId,
                PersonnelId = doctor.Id,
                Status = "Выполнено",
                AppointmentType = selectedAppointment.AppointmentType,
                AppointmentTime = DateTime.Now
            });

            LoadAppointments();
        }
        else
        {
            MessageBox.Show("Выберите назначение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
