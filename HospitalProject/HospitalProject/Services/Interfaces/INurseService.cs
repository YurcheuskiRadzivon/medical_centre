using System.Collections.Generic;
using HospitalProject.Business.Entities.Personnel;

public interface INurseService
{
    IEnumerable<Nurse> GetAllNurses();
    Nurse GetNurseById(int id);
    void CreateNurse(Nurse nurse);
    void UpdateNurse(Nurse nurse);
    void DeleteNurse(int id);
}
