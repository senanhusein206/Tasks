using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTask.Hospital;

public class Appointment
{
    public int PatientId
    {
        get;
        set;

    }


    private int _doctorId;
    public int DoctorId
    {
        get;
        set;

    }
    public DateTime DateTime { get; set; }

    public Appointment(int patientid, int doctorid, DateTime datatime)
    {
        PatientId = patientid;
        DoctorId = doctorid;
        DateTime = datatime;
    }

    public override string ToString()
    {
        return $"doctor id: {DoctorId} patient id: {PatientId} Datetime{DateTime}";
    }
}
