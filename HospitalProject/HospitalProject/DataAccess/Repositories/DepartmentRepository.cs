using System.Collections.Generic;
using System.Linq;
using HospitalProject.Business.Entities;
using HospitalProject.Business.Entities.Departments;

public class DepartmentRepository
{
    private readonly Hospital _hospital;

    public DepartmentRepository(Hospital hospital)
    {
        _hospital = hospital;
    }

    public IQueryable<Department> GetAll()
    {
        return _hospital.Departments.AsQueryable();
    }

    public Department GetById(int id)
    {
        return _hospital.Departments.FirstOrDefault(d => d.Id == id);
    }

    public void Add(Department department)
    {
        _hospital.Departments.Add(department);
    }

    public void Update(Department department)
    {
        var existingDepartment = GetById(department.Id);
        if (existingDepartment != null)
        {
            var index = _hospital.Departments.IndexOf(existingDepartment);
            _hospital.Departments[index] = department;
        }
    }

    public void Remove(Department department)
    {
        _hospital.Departments.Remove(department);
    }
}
