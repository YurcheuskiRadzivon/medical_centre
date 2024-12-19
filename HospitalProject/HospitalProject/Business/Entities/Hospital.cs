using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using HospitalProject.Business.Entities.Appointments;
using HospitalProject.Business.Entities.Departments;
using HospitalProject.Business.Entities.Patients;
using HospitalProject.Business.Entities.Personnel;

namespace HospitalProject.Business.Entities
{
    public class Hospital
    {
        public List<Doctor> Doctors { get; set; }
        public List<Nurse> Nurses { get; set; }
        public List<Department> Departments { get; set; }
        public List<Patient> Patients { get; set; }
        public List<Appointment> Appointments { get; set; }
        public IdSaving IdSaving { get; set; }
    }


}
