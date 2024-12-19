using System.Collections.Generic;
using HospitalProject.Business.Entities.Personnel;

using HospitalProject.Business.Entities;

public class DoctorService : IDoctorService
{
    private readonly DoctorRepository _repository;

    public DoctorService(Hospital hospital)
    {
        _repository = new DoctorRepository(hospital);
    }

    public IEnumerable<Doctor> GetAllDoctors()
    {
        return _repository.GetAll().ToList();
    }

    public Doctor GetDoctorById(int id)
    {
        return _repository.GetById(id);
    }

    public void CreateDoctor(Doctor doctor)
    {

        _repository.Add(doctor);
    }

    public void UpdateDoctor(Doctor doctor)
    {
        _repository.Update(doctor);
    }

    public void DeleteDoctor(int id)
    {
        var doctor = _repository.GetById(id);
        if (doctor != null)
        {
            _repository.Remove(doctor);
        }
    }
}
