using System.Collections.Generic;
using HospitalProject.Business.Entities.Appointments;
using HospitalProject.Business.Entities;



public class AppointmentService : IAppointmentService
{
    private readonly AppointmentRepository _repository;

    public AppointmentService(Hospital hospital)
    {
        _repository = new AppointmentRepository(hospital);
    }

    public IEnumerable<Appointment> GetAllAppointments()
    {
        return _repository.GetAll().ToList();
    }

    public Appointment GetAppointmentById(int id)
    {
        return _repository.GetById(id);
    }

    public void CreateAppointment(Appointment appointment)
    {
        _repository.Add(appointment);
    }

    public void UpdateAppointment(Appointment appointment)
    {
        _repository.Update(appointment);
    }

    public void DeleteAppointment(int id)
    {
        var appointment = _repository.GetById(id);
        if (appointment != null)
        {
            _repository.Remove(appointment);
        }
    }
}
