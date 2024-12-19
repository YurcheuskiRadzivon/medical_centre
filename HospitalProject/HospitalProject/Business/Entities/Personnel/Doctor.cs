using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Business.Entities.Personnel
{
    public class Doctor : Person
    {
        public int DepartmentId { get; set; }
        public string Specialty { get; set; }
    }

}
