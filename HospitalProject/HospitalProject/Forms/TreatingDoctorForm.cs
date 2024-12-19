using System;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using HospitalProject.Business.Entities.Personnel;
using HospitalProject.Business.Entities.Patients;
using HospitalProject.Business.Entities;


public partial class TreatingDoctorForm : Form
{
    private readonly IDoctorService _doctorService;
    private readonly IPatientService _patientService;
    private readonly Hospital _hospital;
    private readonly Doctor _doctor;

    public TreatingDoctorForm(Hospital hospital, Doctor doctor)
    {
        _doctorService = new DoctorService(hospital);
        _patientService = new PatientService(hospital);
        _hospital = hospital;
        _doctor = doctor;
        InitializeComponent();
        LoadPatients();
    }

    private void LoadPatients()
    {
        lvPatients.Items.Clear(); // Очистить список перед добавлением новых элементов

        var patients = _patientService.GetAllPatients().Where(p => p.PersonId == _doctor.Id).ToList();
        foreach (var patient in patients)
        {
            var listItem = new ListViewItem(new[] {
                patient.Id.ToString(),
                patient.FirstName,
                patient.LastName,
                patient.MiddleName,
                patient.diagnosis
            });
            lvPatients.Items.Add(listItem);
        }
    }

    private void BtnCreateAppointment_Click(object sender, EventArgs e)
    {
        if (lvPatients.SelectedItems.Count > 0)
        {
            var selectedPatientId = int.Parse(lvPatients.SelectedItems[0].SubItems[0].Text);
            var selectedPatient = _patientService.GetPatientById(selectedPatientId);
            var createAppointmentForm = new CreateAppointmentForm(_hospital, selectedPatient);
            createAppointmentForm.AppointmentCreated += (s, ev) => LoadPatients();
            createAppointmentForm.Show();
        }
        else
        {
            MessageBox.Show("Выберите пациента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnViewMedicalRecord_Click(object sender, EventArgs e)
    {
        if (lvPatients.SelectedItems.Count > 0)
        {
            var selectedPatientId = int.Parse(lvPatients.SelectedItems[0].SubItems[0].Text);
            var selectedPatient = _patientService.GetPatientById(selectedPatientId);
            var medicalRecordForm = new MedicalRecordForm(_hospital, selectedPatient);
            medicalRecordForm.Show();
        }
        else
        {
            MessageBox.Show("Выберите пациента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnDischargePatient_Click(object sender, EventArgs e)
    {
        if (lvPatients.SelectedItems.Count > 0)
        {
            var selectedPatientId = int.Parse(lvPatients.SelectedItems[0].SubItems[0].Text);
            var selectedPatient = _patientService.GetPatientById(selectedPatientId);

            ExportMedicalRecordToPdf(selectedPatient);

            _patientService.DeletePatient(selectedPatientId);

            LoadPatients();
        }
        else
        {
            MessageBox.Show("Выберите пациента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ExportMedicalRecordToPdf(Patient patient)
    {
        // Регистрация кодировок
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

        string fileName = $"{patient.LastName}_{patient.FirstName}_{patient.MiddleName}.pdf";
        using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
        {
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();

            // Используем шрифт Arial, поддерживающий кириллицу
            string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
            BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 12);

            // Заголовок документа
            Paragraph title = new Paragraph($"Медицинская карта пациента: {patient.LastName} {patient.FirstName} {patient.MiddleName}", font)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingAfter = 20
            };
            doc.Add(title);

            // Информация о пациенте
            doc.Add(new Paragraph("Информация о пациенте:", font));
            doc.Add(new Paragraph($"Имя: {patient.FirstName}", font));
            doc.Add(new Paragraph($"Фамилия: {patient.LastName}", font));
            doc.Add(new Paragraph($"Отчество: {patient.MiddleName}", font));
            doc.Add(new Paragraph($"Диагноз: {patient.diagnosis}", font));
            doc.Add(new Paragraph(" ", font));

            // Назначения
            doc.Add(new Paragraph("Назначения:", font));
            foreach (var appointment in patient.MedicalRecord.Appointments)
            {
                doc.Add(new Paragraph($"Назначение ID: {appointment.Id}", font));
                doc.Add(new Paragraph($"Описание: {appointment.Description}", font));
                doc.Add(new Paragraph($"Тип: {appointment.AppointmentType.Name}", font));
                doc.Add(new Paragraph($"Время: {appointment.AppointmentTime}", font));
                doc.Add(new Paragraph($"Статус: {appointment.Status}", font));
                doc.Add(new Paragraph(" ", font));
            }

            doc.Close();
            writer.Close();
        }
    }







}
