using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.Models
{
    public class JoursFerie
    {
        public int ID { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public int NbJours { get; set; }

        public int Annee { get; set; }

        public int ISAllYear { get; set; }

    }
}
