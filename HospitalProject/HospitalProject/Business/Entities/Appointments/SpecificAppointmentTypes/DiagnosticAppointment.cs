using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalProject.Business.Entities.Appointments;

namespace HospitalProject.Business.Entities.Appointments.SpecificAppointmentTypes
{
    public class DiagnosticAppointment : TypeAppointment
    {
        public string DiagnosticTool { get; set; } // Инструмент диагностики
    }

}
