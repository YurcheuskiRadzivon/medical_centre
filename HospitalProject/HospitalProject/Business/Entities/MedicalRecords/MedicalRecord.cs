﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalProject.Business.Entities.Appointments;

namespace HospitalProject.Business.Entities.MedicalRecords
{
    public class MedicalRecord
    {
        public int PatientId { get; set; }
        public List<Appointment> Appointments { get; set; }
    }

}
