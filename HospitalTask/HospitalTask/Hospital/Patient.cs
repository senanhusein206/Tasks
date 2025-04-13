using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTask.Hospital;

public class Patient:PersonBase
{
    private int _id;
    public int Id
    {
        get { return _id; }
        set
        {
            _id++;
            Id = _id;
        }
    }


    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public Genders Gender { get; set; }
    public Patient(string name, string surname, int age, Genders gender)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Gender = gender;

    }
    public override string ToString()
    {
        return $"Patient adi: {Name} Patient soyadi: {Surname}  Patientin yasi: {Age} Patientin cinsi: {Gender}";
    }
}
