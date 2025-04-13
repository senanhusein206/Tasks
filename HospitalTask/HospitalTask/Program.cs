using HospitalTask.Hospital;

namespace HospitalTask;

internal class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("1.Yeni xəstə əlavə et");
            Console.WriteLine("2.Yeni həkim əlavə et");
            Console.WriteLine("3.Həkimə xəstə təyin et");
            Console.WriteLine("4.Xəstələrin siyahısı");
            Console.WriteLine("5.Həkimlərin siyahısı");
            Console.WriteLine("6.Statistikaya bax");
            Console.WriteLine("7.Çıxış");

            Console.WriteLine("deyeri daxil edin");
            string point = Console.ReadLine();
            switch (point)

            {
                case "1":
                    Console.WriteLine("xesdenin adini daxil edin");
                    string name = Console.ReadLine();
                    Console.WriteLine("Xesdenin soyadi");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Xesdenin yasini daxil edin");
                    int age = int.Parse(Console.ReadLine());

                    Console.WriteLine("Xesdenin genderi");
                    string genderinput = Console.ReadLine();
                    Enum.TryParse(genderinput,out Genders gender);
                    Patient patient = new Patient(name, surname, age, gender);

                    DBContext.AddNewPatient(patient);
                    DBContext.GetAllPatient();

                    break;

                case "2":
                    Console.WriteLine("Hekimin adini daxil edin");
                    string name1 = Console.ReadLine();
                    Console.WriteLine("Hekimin soyadi");
                    string surname1 = Console.ReadLine();
                    Console.WriteLine("hekimin yasini daxil edin");
                    int age1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Hekimin genderini daxil edin");
                    string genderinput1 = Console.ReadLine();
                    Enum.TryParse(genderinput1, out Genders gender1);

                    Doctor doctor = new Doctor(name1, surname1,age1,gender1);

                    DBContext.AddNewDoctor(doctor);
                    DBContext.GetAllPatient();


                    break;

                case "3":
                    Console.WriteLine("Hekimin id sini daxil edin");
                    int doctorId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Xesdeenin Idsini daxil edin");
                    int patientId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Xesteye tarix daxil edin");
                    DateTime datatime = DateTime.Parse(Console.ReadLine());

                    Appointment appointment = new Appointment(doctorId, patientId,datatime);
                    DBContext.AddNewAppointment(appointment);
                    foreach (var item in DBContext.appointments)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case "4":
                    if (DBContext.patients.Length == 0)
                    {
                        Console.WriteLine("bosdurrr");
                    }
                    else
                    {
                        foreach (Patient item in DBContext.patients)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case "5":
                    if (DBContext.doctors.Length == 0)
                    {
                        Console.WriteLine("bosdurrr");
                    }
                    else
                    {
                        foreach (Doctor item in DBContext.doctors)
                        {
                            Console.WriteLine(item);
                        }
                    }

                    break;
                case "6":
                    Console.WriteLine(HospitalStats.TotalPatientCount);
                    Console.WriteLine(HospitalStats.TotalDoctorCount);
                    Console.WriteLine(HospitalStats.TotalAppointmentCount);
                    break;

                case "7":
                    Console.Clear();

                    break;

                default:
                    Console.WriteLine("duzgun secim edin");
                    break;
            }
        } while (true);
    }
}
