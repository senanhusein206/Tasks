using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTask.Hospital;

public class PersonBase: IPerson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public Genders Gender { get; set; }

    public string GetFullName()
    {
        return $"{Name} {Surname}";
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"{Name}\n{Surname} \n{Id}\n{Gender}");
    }
}
