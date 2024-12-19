using HospitalProject.Business.Entities;
using HospitalProject.Business.Entities.Patients;
using System;
using System.Linq;
using System.Windows.Forms;

public partial class MedicalRecordForm : Form
{
    private Hospital hospital;
    private Patient patient;

    public MedicalRecordForm(Hospital hospital, Patient patient)
    {
        this.hospital = hospital;
        this.patient = patient;
        InitializeComponent();
        LoadMedicalRecord();
    }

    private void LoadMedicalRecord()
    {
        var appointments = patient.MedicalRecord.Appointments;
        foreach (var appointment in appointments)
        {
            var listItem = new ListViewItem(new[] {
                appointment.Id.ToString(),
                appointment.Description,
                appointment.AppointmentType.ToString(),
                appointment.AppointmentTime.ToString("g")
            });
            lvMedicalRecord.Items.Add(listItem);
        }
    }
}
