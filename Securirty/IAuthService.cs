using EmployeeApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.Securirty
{
    public interface IAuthentificationService
    {
         Task<User> SignUpEmployee(Employee employee);

         void SendEmail(string to,string password);

        Task EditPassword(string id, string password);

        Task<SignInEmployeeResponse> SignInEmployee(SignInDTO signInDTO);
    }
}
