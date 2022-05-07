using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.Models
{
    public class SignInEmployeeResponse
    {
        public string token { get; set; }
        public Employee employee { get; set; }

    }
}
