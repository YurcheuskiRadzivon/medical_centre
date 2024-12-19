using System.Collections.Generic;
using System.Linq;
using HospitalProject.Business.Entities;
using HospitalProject.Business.Entities.Personnel;

public class NurseRepository
{
    private readonly Hospital _hospital;

    public NurseRepository(Hospital hospital)
    {
        _hospital = hospital;
    }

    public IQueryable<Nurse> GetAll()
    {
        return _hospital.Nurses.AsQueryable();
    }

    public Nurse GetById(int id)
    {
        return _hospital.Nurses.FirstOrDefault(n => n.Id == id);
    }

    public void Add(Nurse nurse)
    {
        _hospital.IdSaving.PersonId++;
        nurse.Id = _hospital.IdSaving.PersonId;
        _hospital.Nurses.Add(nurse);
    }

    public void Update(Nurse nurse)
    {
        var existingNurse = GetById(nurse.Id);
        if (existingNurse != null)
        {
            var index = _hospital.Nurses.IndexOf(existingNurse);
            _hospital.Nurses[index] = nurse;
        }
    }

    public void Remove(Nurse nurse)
    {
        _hospital.Nurses.Remove(nurse);
    }
}
