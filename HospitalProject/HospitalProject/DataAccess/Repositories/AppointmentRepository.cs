using System.Collections.Generic;
using System.Linq;
using HospitalProject.Business.Entities;
using HospitalProject.Business.Entities.Appointments;
using HospitalProject.Business.Entities.Personnel;

public class AppointmentRepository
{
    private readonly Hospital _hospital;

    public AppointmentRepository(Hospital hospital)
    {
        _hospital = hospital;
    }

    public IQueryable<Appointment> GetAll()
    {
        return _hospital.Appointments.AsQueryable();
    }

    public Appointment GetById(int id)
    {
        return _hospital.Appointments.FirstOrDefault(a => a.Id == id);
    }

    public void Add(Appointment appointment)
    {
        _hospital.IdSaving.AppointmentId++;
        appointment.Id = _hospital.IdSaving.AppointmentId;
        _hospital.Appointments.Add(appointment);
    }

    public void Update(Appointment appointment)
    {
        var existingAppointment = GetById(appointment.Id);
        if (existingAppointment != null)
        {
            var index = _hospital.Appointments.IndexOf(existingAppointment);
            _hospital.Appointments[index] = appointment;
        }
    }

    public void Remove(Appointment appointment)
    {
        _hospital.Appointments.Remove(appointment);
    }
}
