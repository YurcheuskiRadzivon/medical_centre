using HospitalProject.Business.Entities;
using HospitalProject.Business.Entities.Personnel;
using HospitalProject.Business.Entities.Appointments;

using System;
using System.Linq;
using System.Windows.Forms;

public partial class NurseForm : Form
{
    private Hospital hospital;
    private Nurse nurse;

    public NurseForm(Hospital hospital, Nurse nurse)
    {
        this.hospital = hospital;
        this.nurse = nurse;
        InitializeComponent();
        LoadAppointments();
    }

    private void LoadAppointments()
    {
        var appointments = hospital.Patients
            .SelectMany(p => p.MedicalRecord.Appointments)
            .Where(a => a.PersonnelId == nurse.Id)
            .ToList();

        foreach (var appointment in appointments)
        {
            var listItem = new ListViewItem(new[] {
                appointment.Id.ToString(),
                appointment.Description,
                appointment.AppointmentType.ToString(),
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

            var completionAppointment = new Appointment
            {
                Id = hospital.IdSaving.AppointmentId++,
                Description = $"Процедура по назначению {selectedAppointment.Description} выполнена",
                PatientId = selectedAppointment.PatientId,
                PersonnelId = nurse.Id,
                AppointmentType = selectedAppointment.AppointmentType,
                AppointmentTime = DateTime.Now
            };

            var patient = hospital.Patients.First(p => p.Id == selectedAppointment.PatientId);
            patient.MedicalRecord.Appointments.Add(completionAppointment);
            LoadAppointments();
        }
        else
        {
            MessageBox.Show("Выберите назначение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
