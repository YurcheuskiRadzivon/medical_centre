using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalProject.Business.Entities.Appointments;

namespace HospitalProject.Business.Entities.Appointments.SpecificAppointmentTypes
{
    public class PreventiveAppointment : TypeAppointment
    {
        public string PreventiveMeasure { get; set; } // Мера профилактики
    }

}
