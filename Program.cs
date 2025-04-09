using lab6Koop;


class Program
{
    static void Main(string[] args)
    {
       
        Clinic clinic = new Clinic("MidleHospital","Cool Sity,st Roll");
        Doctor doctor = new Doctor("Alex",clinic);
        Console.WriteLine(doctor.GetClinicName());
        // Виведе:
        // Starting car: Tesla
        // Engine started!
    }
}