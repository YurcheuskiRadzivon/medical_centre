using System.Collections.Generic;
using HospitalProject.Business.Entities.Personnel;

using HospitalProject.Business.Entities;

public class NurseService : INurseService
{
    private readonly NurseRepository _repository;

    public NurseService(Hospital hospital)
    {
        _repository = new NurseRepository(hospital);
    }

    public IEnumerable<Nurse> GetAllNurses()
    {
        return _repository.GetAll().ToList();
    }

    public Nurse GetNurseById(int id)
    {
        return _repository.GetById(id);
    }

    public void CreateNurse(Nurse nurse)
    {
        _repository.Add(nurse);
    }

    public void UpdateNurse(Nurse nurse)
    {
        _repository.Update(nurse);
    }

    public void DeleteNurse(int id)
    {
        var nurse = _repository.GetById(id);
        if (nurse != null)
        {
            _repository.Remove(nurse);
        }
    }
}
