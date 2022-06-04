using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.Models
{
    public class Contrat
    {
        public int ID { get; set; }

        public string type { get; set; }

        public float SalaireBrut { get; set; }

        public float SalaireNet { get; set; }

        public int EmployeeID { get; set; }

        public Employee Employee { get; set; }

        public float PrimeDeMois { get; set; }

    }
}
