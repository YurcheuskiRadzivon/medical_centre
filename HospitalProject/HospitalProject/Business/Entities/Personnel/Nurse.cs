using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Business.Entities.Personnel
{
    public class Nurse : Person
    {
        public int DepartmentId { get; set; }
    }

}
