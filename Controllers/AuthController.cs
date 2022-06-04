using EmployeeApplication.Models;
using EmployeeApplication.Securirty;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EmployeeApplication.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthentificationService _AuthService;
      
        public AuthController(IAuthentificationService AuthService)
        {
            _AuthService = AuthService;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return Redirect("/");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(SignInDTO signInDTO)
        {
           ErrorViewModel errorViewModel=null;
            try

            {
                SignInEmployeeResponse signInEmployeeResponse = await _AuthService.SignInEmployee(signInDTO);
                if (signInEmployeeResponse != null)
                {

                    HttpContext.Session.SetString("EmployeeID", signInEmployeeResponse.employee.IdEmployee.ToString());
                    HttpContext.Session.SetString("Email", signInEmployeeResponse.employee.Email.ToString());
                    HttpContext.Session.SetString("token", signInEmployeeResponse.token);
                    if(!signInDTO.Identify.Equals("rhapplication40@gmail.com"))
                    HttpContext.Session.SetString("Role", "Employee");
                    else
                        HttpContext.Session.SetString("Role", "RH");
                    if (!string.IsNullOrEmpty(signInEmployeeResponse.employee.Image))
                    HttpContext.Session.SetString("Image", signInEmployeeResponse.employee.Image);
                    
                    return Redirect("/Home");
                }
            }
            catch (Exception Ex)
            {
               errorViewModel = new ErrorViewModel()
                {
                    Code = "501",
                    Message = Ex.Message
                };

            }
           
          return View("~/Views/Shared/Error.cshtml",errorViewModel);
        }


    }
}
