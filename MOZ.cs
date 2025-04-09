using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab6Koop
{
    internal class MOZ
    {

        public string FormVaccinationPlan(string plan)
        {
            Console.WriteLine("План зформовано");
            return plan;
        }
        public void DeliveryVaccie(Clinic clinic,Vaccine vaccine)
        {
            clinic.hasVaccine.Add(vaccine.GetName());
        }
        public void AnalyzReport(string report) 
        {
            Console.WriteLine("MOZ аналізує звіти");
        }
    }
}
