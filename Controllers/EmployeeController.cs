using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeApplication.Models;
using EmployeeApplication.Securirty;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace EmployeeApplication.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly Models.AppDbContext _context;
        private readonly IWebHostEnvironment hostingEnvironment;
        private readonly IAuthentificationService _AuthService;

        public EmployeeController(Models.AppDbContext context, IAuthentificationService AuthService,IWebHostEnvironment env)
        {
            _context = context;
            _AuthService = AuthService;
            hostingEnvironment = env;
        }

        // GET: Employee
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employees.ToListAsync());
        }

        // GET: Employee/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.IdEmployee == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employee/Create
        public IActionResult Create()
        {
            List<Contrat> contrats = _context.Contrats.ToList();
            ViewBag.Contracts = contrats;
            return View();
        }

        // POST: Employee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Employee employee)
        {
            string uniqueFileName =null;
            //////////////////////////////////////
            ///////////////////////////////////////
            if (ModelState.IsValid)
            {
                if (employee.ImageFile != null)
                {
                    // The image must be uploaded to the images folder in wwwroot
                    // To get the path of the wwwroot folder we are using the inject
                    // HostingEnvironment service provided by ASP.NET Core

                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");

                    // To make sure the file name is unique we are appending a new
                    // GUID value and an underscore to the file name

                    uniqueFileName = Guid.NewGuid().ToString() + "_" + employee.ImageFile.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    // Use CopyTo() method provided by IFormFile interface to
                    // copy the file to wwwroot/images folder

                    employee.ImageFile.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                Employee employee1 = _context.Employees.Where(e => e.Cin == employee.Cin).FirstOrDefault();
                    if(employee1 != null)
                    {
                    ViewBag.Error = "Cin Existe";
                    return View(employee);
                    }
                    employee1 = _context.Employees.Where(e => e.Email == employee.Email).FirstOrDefault();
                    if (employee1 != null)
                    {
                        ViewBag.Error = "Email Existe";
                        return View(employee);
                    }
                employee1 = _context.Employees.Where(e => e.Telephone == employee.Telephone).FirstOrDefault();
                if (employee1 != null)
                {
                    ViewBag.Error = "Telephone Existe";
                    return View(employee);
                }
                if((DateTime.Now-employee.DateNaissance).Days <6570)
                {
                    ViewBag.Error = "Age doit etre supperieur ou egale a 18 ans";
                    return View(employee);
                }
                employee.Image = uniqueFileName;
                await _context.SaveChangesAsync();
                try {
                User user = await _AuthService.SignUpEmployee(employee);
                    employee.User = user;
                    employee.UserID = user.Id;
                    _context.Employees.Add(employee);
                    await _context.SaveChangesAsync();
                }
                catch(Exception ex)
                {

                }
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employee/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
       // [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Employee employee)
        {
            //if (id != employee.IdEmployee)
            //{
            //    return NotFound();
            //}

            if (ModelState.IsValid)
            {
                try
                {
                    Employee e = _context.Employees.Find(employee.IdEmployee);
                    if (employee.ImageFile != null)
                    {
                        // If a new photo is uploaded, the existing photo must be
                        // deleted. So check if there is an existing photo and delete

                        // Save the new photo in wwwroot/images folder and update
                        // PhotoPath property of the employee object which will be
                        // eventually saved in the database
                        employee.Image = ProcessUploadedFile(employee);
                        HttpContext.Session.SetString("Image", employee.Image);

                    }
                    Employee employee1 = _context.Employees.Where(e => e.Cin == employee.Cin && e.IdEmployee != employee.IdEmployee).FirstOrDefault();
                    if (employee1 != null)
                    {
                        ViewBag.Error = "Cin Existe";
                        return View(employee);
                    }
                    employee1 = _context.Employees.Where(e => e.Email == employee.Email && e.IdEmployee != employee.IdEmployee).FirstOrDefault();
                    if (employee1 != null)
                    {
                        ViewBag.Error = "Email Existe";
                        return View(employee);
                    }
                    employee1 = _context.Employees.Where(e => e.Telephone == employee.Telephone && e.IdEmployee != employee.IdEmployee).FirstOrDefault();
                    if (employee1 != null)
                    {
                        ViewBag.Error = "Téléphone Existe";
                        return View(employee);
                    }
                    if ((DateTime.Now - employee.DateNaissance).Days < 6570)
                    {
                        ViewBag.Error = "Age doit être supérieur ou égale à 18 ans";
                        return View(employee);
                    }
                    employee.UserID = e.UserID;
                    _context.Entry<Employee>(e).State = EntityState.Detached;
                    _context.Employees.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.IdEmployee))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var employee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.IdEmployee == id);
        }
        private string ProcessUploadedFile(Employee employee)
        {
            string uniqueFileName = null;

            if (employee.ImageFile != null)
            {
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + employee.ImageFile.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    employee.ImageFile.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }
        [HttpPost]

        public async Task<IActionResult> EditPassword(Employee employee)
        {
            Employee e = _context.Employees.Find(employee.IdEmployee);
           await  _AuthService.EditPassword(e.UserID, employee.NewPassword);
            return Ok();
        }
    }
}
