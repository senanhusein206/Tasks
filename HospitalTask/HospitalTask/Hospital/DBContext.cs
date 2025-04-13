using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTask.Hospital;

public static class DBContext
{
    public static Patient[] patients = [];
    public static Doctor[] doctors = [];
    public static Appointment[] appointments = [];

    public static void AddNewPatient(Patient patient)
    {
        Array.Resize(ref patients, patients.Length + 1);
        patients[^1] = patient;
        HospitalStats.TotalPatientCount++;
    }
    public static void AddNewDoctor(Doctor doctor)
    {
        Array.Resize(ref doctors, doctors.Length + 1);
        doctors[^1] = doctor;
        HospitalStats.TotalDoctorCount++;
    }
    public static void AddNewAppointment(Appointment appointment)
    {
        Array.Resize(ref appointments, appointments.Length + 1);
        appointments[^1] = appointment;
        HospitalStats.TotalAppointmentCount++;
    }

    public static Patient[] GetAllPatient()
    {
        foreach (var item in patients)
        {
            Console.WriteLine(item.Name);
            Console.WriteLine(item.Surname);
        }
        return null;
    }
    public static Doctor[] GetAllDoctor()
    {
        foreach (var item in patients)
        {
            Console.WriteLine(item.Name);
            Console.WriteLine(item.Surname);

        }
        return null;

    }
    public static Appointment[] GetAllAppointment()
    {
        Console.WriteLine(true);
        foreach (Patient item in patients)
        {
            Console.WriteLine(item.Name);
            Console.WriteLine(item.Surname);

        }
        return null;
    }
}
