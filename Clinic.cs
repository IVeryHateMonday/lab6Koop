using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6Koop
{
    internal class Clinic
    {
        private string Name;
        public List<string> hasVaccine;
        public string Adress;
        public Clinic(string name, string adress)
        {
            this.Adress= adress;
            this.Name = name;
            hasVaccine = new List<string>();
        }
        public string GetName()
        {
            return this.Name;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
        public string UpdateReports(string report)
        {
            return report;
        }
        public string GetReport() 
        {
            return "Надано данні з вакцинації";
        }

        
    }
}
