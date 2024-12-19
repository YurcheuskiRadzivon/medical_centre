using System.Collections.Generic;
using HospitalProject.Business.Entities.Departments;

using HospitalProject.Business.Entities;

public class DepartmentService : IDepartmentService
{
    private readonly DepartmentRepository _repository;

    public DepartmentService(Hospital hospital)
    {
        _repository = new DepartmentRepository(hospital);
    }

    public IEnumerable<Department> GetAllDepartments()
    {
        return _repository.GetAll().ToList();
    }

    public Department GetDepartmentById(int id)
    {
        return _repository.GetById(id);
    }

    public void CreateDepartment(Department department)
    {
        _repository.Add(department);
    }

    public void UpdateDepartment(Department department)
    {
        _repository.Update(department);
    }

    public void DeleteDepartment(int id)
    {
        var department = _repository.GetById(id);
        if (department != null)
        {
            _repository.Remove(department);
        }
    }
}
