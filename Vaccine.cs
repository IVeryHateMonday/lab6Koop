namespace lab6Koop
{
    internal class VaccinationFacade
    {
        private MOZ moz;
        private Clinic clinic;
        private Doctor doctor;

        public VaccinationFacade(Clinic clinic, Doctor doctor)
        {
            this.moz = MOZ.Instance;
            this.clinic = clinic;
            this.doctor = doctor;
        }

        public void ExecuteVaccination(Patient patient, Vaccine vaccine)
        {
            Console.WriteLine("=== Початок вакцинації ===");
            
            // МОЗ доставляє вакцину
            moz.DeliveryVaccie(clinic, vaccine);

            // Пацієнт запитує вакцину
            patient.requestVaccine(vaccine.GetName());

            // Лікар отримує вакцину
            doctor.GetVaccine(vaccine);

            // Лікар вакцинує пацієнта
            string result = doctor.doVaccination(patient, vaccine);
            Console.WriteLine(result);

            // Пацієнт отримує вакцину
            patient.getVaccine();

            // МОЗ аналізує звіт
            moz.AnalyzReport(clinic.GetReport());

            Console.WriteLine("=== Вакцинація завершена ===");
        }
    }
}
