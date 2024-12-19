using System.Collections.Generic;
using HospitalProject.Business.Entities.Patients;

public interface IPatientService
{
    IEnumerable<Patient> GetAllPatients();
    Patient GetPatientById(int id);
    void CreatePatient(Patient patient);
    void UpdatePatient(Patient patient);
    void DeletePatient(int id);
}
