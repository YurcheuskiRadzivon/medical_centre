using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalProject.Business.Entities.Appointments.SpecificAppointmentTypes;
using HospitalProject.Business.Entities.Patients;
using HospitalProject.Business.Entities.Personnel;

namespace HospitalProject.Business.Entities.Departments
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<Nurse> Nurses { get; set; }
        public List<Patient> Patients { get; set; }
        public List<MedicationAppointment> MedicationTypes { get; set; } // Конкретные типы назначений для медикаментов
        public List<DiagnosticAppointment> DiagnosticTypes { get; set; } // Конкретные типы диагностических назначений
        public List<PreventiveAppointment> PreventiveTypes { get; set; } // Конкретные типы профилактических назначений
    }


}
