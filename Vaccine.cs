using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6Koop
{
    internal class Vaccine
    {
        private string name= String.Empty;
        private string serialNumber = String.Empty;
        private string term = String.Empty;
        public string GetName()
        {
            return this.name;
        }
        public Vaccine(string name, string serialNumber, string term) 
        {
            this.name = name;
            this.serialNumber = serialNumber;
            this.term = term;
        }

    }
}
