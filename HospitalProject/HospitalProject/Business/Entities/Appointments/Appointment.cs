using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Business.Entities.Appointments
{
    public class Appointment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int PatientId { get; set; }
        public int PersonnelId { get; set; }

        public string Status { get; set; }

        public TypeAppointment AppointmentType { get; set; }
        public DateTime AppointmentTime { get; set; }
    }



}
