using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalProject.Business.Entities.Appointments;

namespace HospitalProject.Business.Entities.Appointments.SpecificAppointmentTypes
{
    public class MedicationAppointment : TypeAppointment
    {
        public int Quantity { get; set; } // Количество для инъекций
        public int Dosage { get; set; }   // Дозировка для таблеток
    }


}
