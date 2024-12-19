using System.Linq;
using HospitalProject.Business.Entities;

public class HospitalRepository
{
    private readonly DataContext _dataContext;

    public HospitalRepository()
    {
        _dataContext = new DataContext();
    }

    public Hospital LoadHospital()
    {
        return _dataContext.LoadHospitalData();
    }

    public void SaveHospital(Hospital hospital)
    {
        _dataContext.SaveHospitalData(hospital);
    }

    public void UpdateHospital(Hospital updatedHospital)
    {
        var hospital = LoadHospital();
        if (hospital != null)
        {
           
            SaveHospital(updatedHospital);
        }
    }
}
