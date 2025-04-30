using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab6Koop
{
    internal class MOZ
    {
        private static MOZ _instance;

         private MOZ() { }

        public static MOZ Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MOZ();
                }
                return _instance;
            }
        }

        
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
