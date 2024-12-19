using System;
using System.IO;
using System.Xml.Serialization;
using HospitalProject.Business.Entities;
using HospitalProject.Business.Entities.Appointments;
using HospitalProject.Business.Entities.Departments;
using HospitalProject.Business.Entities.Patients;
using HospitalProject.Business.Entities.Personnel;

public class DataContext
{
    private const string FilePath = "hospital.xml";

    public Hospital LoadHospitalData()
    {
        return DeserializeFromFile<Hospital>(FilePath) ?? new Hospital
        {
            Doctors = new List<Doctor>(),
            Nurses = new List<Nurse>(),
            Departments = new List<Department>(),
            Patients = new List<Patient>(),
            Appointments = new List<Appointment>(),
            IdSaving = new IdSaving { PersonId = 1, DepartmentId = 1, PatientId = 1, AppointmentId = 1 }
        };
    }

    public void SaveHospitalData(Hospital hospital)
    {
        SerializeToFile(hospital, FilePath);
    }

    private T DeserializeFromFile<T>(string filePath) where T : class
    {
        if (!File.Exists(filePath))
        {
            return null;
        }

        try
        {
            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                var serializer = new XmlSerializer(typeof(T));
                return serializer.Deserialize(stream) as T;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deserializing file {filePath}: {ex.Message}");
            return null;
        }
    }

    private void SerializeToFile<T>(T obj, string filePath)
    {
        try
        {
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stream, obj);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error serializing to file {filePath}: {ex.Message}");
        }
    }
}
