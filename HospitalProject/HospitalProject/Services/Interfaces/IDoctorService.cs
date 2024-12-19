using System.Collections.Generic;
using HospitalProject.Business.Entities.Personnel;

public interface IDoctorService
{
    IEnumerable<Doctor> GetAllDoctors();
    Doctor GetDoctorById(int id);
    void CreateDoctor(Doctor doctor);
    void UpdateDoctor(Doctor doctor);
    void DeleteDoctor(int id);
}
