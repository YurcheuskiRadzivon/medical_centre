using System.Collections.Generic;
using System.Linq;
using HospitalProject.Business.Entities;
using HospitalProject.Business.Entities.Patients;
using HospitalProject.Business.Entities.Personnel;

public class PatientRepository
{
    private readonly Hospital _hospital;

    public PatientRepository(Hospital hospital)
    {
        _hospital = hospital;
    }

    public IQueryable<Patient> GetAll()
    {
        return _hospital.Patients.AsQueryable();
    }

    public Patient GetById(int id)
    {
        return _hospital.Patients.FirstOrDefault(p => p.Id == id);
    }

    public void Add(Patient patient)
    {
        _hospital.IdSaving.PatientId++;
        patient.Id = _hospital.IdSaving.PatientId;
        _hospital.Patients.Add(patient);
    }

    public void Update(Patient patient)
    {
        var existingPatient = GetById(patient.Id);
        if (existingPatient != null)
        {
            var index = _hospital.Patients.IndexOf(existingPatient);
            _hospital.Patients[index] = patient;
        }
    }

    public void Remove(Patient patient)
    {
        _hospital.Patients.Remove(patient);
    }
}
