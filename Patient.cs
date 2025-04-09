using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6Koop
{
    internal class Patient
    {
        private string Name;

        public List<Vaccine> VaccineList;
        public Patient(string name) 
        {
            this.Name = name;
            VaccineList = new List<Vaccine>();
        }
        public void requestVaccine(string name)
        {
            Console.WriteLine("Запит створено");
        }
        public void getVaccine()
        {
            Console.WriteLine("Вакцину отримано");
        }
        public string getName() 
        {
            return this.Name;
        }
    }
}
