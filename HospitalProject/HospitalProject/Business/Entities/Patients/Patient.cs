using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalProject.Business.Entities.MedicalRecords;

namespace HospitalProject.Business.Entities.Patients
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public int PersonId { get; set; }
        public int DepartmentId { get; set; }
        public string diagnosis { get; set; }

        public MedicalRecord MedicalRecord { get; set; }

    }

}
