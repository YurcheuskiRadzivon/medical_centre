using System.Collections.Generic;
using System.Linq;
using HospitalProject.Business.Entities;
using HospitalProject.Business.Entities.Personnel;

public class DoctorRepository
{
    private readonly Hospital _hospital;

    public DoctorRepository(Hospital hospital)
    {
        _hospital = hospital;
    }

    public IQueryable<Doctor> GetAll()
    {
        return _hospital.Doctors.AsQueryable();
    }

    public Doctor GetById(int id)
    {
        return _hospital.Doctors.FirstOrDefault(d => d.Id == id);
    }

    public void Add(Doctor doctor)
    {
        _hospital.IdSaving.PersonId++;
        doctor.Id = _hospital.IdSaving.PersonId;
        _hospital.Doctors.Add(doctor);
    }

    public void Update(Doctor doctor)
    {
        var existingDoctor = GetById(doctor.Id);
        if (existingDoctor != null)
        {
            var index = _hospital.Doctors.IndexOf(existingDoctor);
            _hospital.Doctors[index] = doctor;
        }
    }

    public void Remove(Doctor doctor)
    {
        _hospital.Doctors.Remove(doctor);
    }
}
