using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeApplication.Models;
using EmployeeApplication.Securirty;

namespace EmployeeApplication.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly Models.AppDbContext _context;

        private readonly IAuthentificationService _AuthService;

        public EmployeeController(Models.AppDbContext context, IAuthentificationService AuthService)
        {
            _context = context;
            _AuthService = AuthService;
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
            return View();
        }

        // POST: Employee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEmployee,Cin,Nom,Prenom,DateNaissance,Email,Telephone,Adresse,Sexe,DateEmbauché,SoldeCongé")] Employee employee)
        {
            
            if (ModelState.IsValid)
            {
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
        public async Task<IActionResult> Edit(int id, [Bind("IdEmployee,Cin,Nom,Prenom,DateNaissance,Email,Telephone,Adresse,Sexe,DateEmbauché,SoldeCongé")] Employee employee)
        {
            if (id != employee.IdEmployee)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
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
                        ViewBag.Error = "Telephone Existe";
                        return View(employee);
                    }
                    if ((DateTime.Now - employee.DateNaissance).Days < 6570)
                    {
                        ViewBag.Error = "Age doit etre supperieur ou egale a 18 ans";
                        return View(employee);
                    }

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
    }
}
