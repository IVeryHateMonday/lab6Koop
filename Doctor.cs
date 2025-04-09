using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6Koop
{
    internal class Doctor
    {
        private string Name;
        private string ClinicName;
        public Doctor(string name, Clinic clinic) 
        { 
            this.Name = name;
            this.ClinicName = clinic.GetName();
        }
        public void GetVaccine(Vaccine vaccine) 
        {
            Console.WriteLine($"Отримана вакцина {vaccine}");
        }
        public string doVaccination(Patient patient,Vaccine vaccine)
        {
            return $"Пацієнт {patient.getName()} отримав {vaccine.GetName()}";
        }
        public string GetClinicName() 
        {
            return ClinicName; 
        }

    }
}
