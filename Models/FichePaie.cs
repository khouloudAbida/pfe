using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.Models
{
    public class FichePaie
    {
        public int ID { get; set; }
        public int Mois { get; set; }

        public float Montant { get; set; }

        public float prime { get; set; }
        public int Annee { get; set; }
        public DateTime dateVirement { get; set; }
        //

        public int EmployeeID { get; set; }

        public Employee Employee { get; set; }
    }
}
