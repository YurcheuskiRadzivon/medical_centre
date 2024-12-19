using HospitalProject.Business.Entities;


public class HospitalService : IHospitalService
{
    private readonly HospitalRepository _repository;

    public HospitalService()
    {
        _repository = new HospitalRepository();
    }

    public Hospital LoadHospitalData()
    {
        return _repository.LoadHospital();
    }

    public void SaveHospitalData(Hospital hospital)
    {
        _repository.SaveHospital(hospital);
    }

    public void UpdateHospitalData(Hospital hospital)
    {
        _repository.UpdateHospital(hospital);
    }
}
