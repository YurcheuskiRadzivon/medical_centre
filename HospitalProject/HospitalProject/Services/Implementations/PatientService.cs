using System.Collections.Generic;
using HospitalProject.Business.Entities.Patients;

using HospitalProject.Business.Entities;

public class PatientService : IPatientService
{
    private readonly PatientRepository _repository;

    public PatientService(Hospital hospital)
    {
        _repository = new PatientRepository(hospital);
    }

    public IEnumerable<Patient> GetAllPatients()
    {
        return _repository.GetAll().ToList();
    }

    public Patient GetPatientById(int id)
    {
        return _repository.GetById(id);
    }

    public void CreatePatient(Patient patient)
    {
        _repository.Add(patient);
    }

    public void UpdatePatient(Patient patient)
    {
        _repository.Update(patient);
    }

    public void DeletePatient(int id)
    {
        var patient = _repository.GetById(id);
        if (patient != null)
        {
            _repository.Remove(patient);
        }
    }
}
