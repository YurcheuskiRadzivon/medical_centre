using HospitalProject.Business.Entities;

public interface IHospitalService
{
    Hospital LoadHospitalData();
    void SaveHospitalData(Hospital hospital);
    void UpdateHospitalData(Hospital hospital);
}
