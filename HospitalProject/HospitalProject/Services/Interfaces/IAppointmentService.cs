using System.Collections.Generic;
using HospitalProject.Business.Entities.Appointments;

public interface IAppointmentService
{
    IEnumerable<Appointment> GetAllAppointments();
    Appointment GetAppointmentById(int id);
    void CreateAppointment(Appointment appointment);
    void UpdateAppointment(Appointment appointment);
    void DeleteAppointment(int id);
}
