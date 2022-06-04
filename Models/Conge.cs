using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.Models
{
    public class Conge
    {

        public int ID { get; set; }

        public DateTime DU { get; set; }
        public DateTime AU { get; set; }

        public string Notes { get; set; }

        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public int IdType { get; set; }
        public int TypeCongeID { get; set; }
        public TypeConge TypeConge { get; set; }
        public int status {get;set;}

        public float NbHours { get; set; }
    }
}
