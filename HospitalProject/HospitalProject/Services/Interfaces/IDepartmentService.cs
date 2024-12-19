using System.Collections.Generic;
using HospitalProject.Business.Entities.Departments;

public interface IDepartmentService
{
    IEnumerable<Department> GetAllDepartments();
    Department GetDepartmentById(int id);
    void CreateDepartment(Department department);
    void UpdateDepartment(Department department);
    void DeleteDepartment(int id);
}
