using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6Koop
{
    internal class ClinicHead
    {
        private string Name;
        private string ClinicName;
        public ClinicHead(string name,Clinic clinic)
        {
            this.Name = name;
            this.ClinicName= clinic.GetName();
        }
        public string CreateReport( string report)
        {
            return report;
        }
        public void AnalyzReport()
        {

        }
        public string CreateRequestVaccine(string requestVaccine)
        {
            return requestVaccine;
        }
        
        

    }
}
