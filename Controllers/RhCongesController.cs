using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeApplication.Models;

namespace EmployeeApplication.Controllers
{
    public class RhCongesController : Controller
    {
        private readonly AppDbContext _context;

        public RhCongesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: RhConges
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Conges.Include(c => c.Employee).Include(c => c.TypeConge);
            return View(await appDbContext.ToListAsync());
        }

        public async Task<IActionResult> SetStatus(int CongeID,int status)
        {
            var conge = _context.Conges.Find(CongeID);
            if(conge != null)
            {
                conge.status = status;
                _context.Update(conge);
                if(status == 1)
                {
                    Employee emp = _context.Employees.Where(e => e.IdEmployee == conge.EmployeeID).First();
                    emp.SoldeCongé -= conge.NbHours;
                    _context.Employees.Update(emp);

                }
                _context.SaveChanges();
            }
            var appDbContext = _context.Conges.Include(c => c.Employee).Include(c => c.TypeConge);
            return View("index",await appDbContext.ToListAsync());

        }

        public IActionResult CalculerSalaire()
        {
            List<Contrat> contrats = _context.Contrats.Include("Employee").ToList();
            foreach(Contrat c in contrats)
            {
                FichePaie f = _context.FichePaies.Where(f => f.Annee == DateTime.Now.Year && f.Mois == DateTime.Now.Month && f.EmployeeID == c.EmployeeID).FirstOrDefault();
                if (f == null)
                {
                    float totalConge = 0;
                    FichePaie fichePaie = new FichePaie();
                    fichePaie.Annee = DateTime.Now.Year;
                    fichePaie.Mois = DateTime.Now.Month;
                    fichePaie.EmployeeID = c.EmployeeID;
                    fichePaie.Montant = c.SalaireNet;
                    List<Conge> conges = _context.Conges.Where(cn => cn.EmployeeID == c.EmployeeID && cn.DU.Year == DateTime.Now.Year && cn.DU.Month == DateTime.Now.Month).ToList();
                    Employee emp = _context.Employees.Where(e => e.IdEmployee == c.EmployeeID).FirstOrDefault();

                    foreach (Conge conge in conges)
                    {
                        totalConge = totalConge + (float)(conge.NbHours / 8);
                        

                    }
                    totalConge -= (float)1.5;
                    if (c.Employee.SoldeCongé >= totalConge)
                    {
                        
                        emp.SoldeCongé  -= totalConge ;
                    }
                    else
                    {
                        totalConge -= c.Employee.SoldeCongé ;
                        emp.SoldeCongé = 0;
                        fichePaie.Montant -= totalConge * (c.SalaireNet / 26);
                    }
                    fichePaie.prime = c.PrimeDeMois;
                    fichePaie.dateVirement = DateTime.Now;
                    _context.FichePaies.Add(fichePaie);
                    _context.Employees.Update(emp);
                  
                    _context.SaveChanges();
                }


            }
            List<FichePaie> fichePaies = _context.FichePaies.Include("Employee").ToList();
            return View("Paie", fichePaies);
           
        }

        public IActionResult Paie()
        {
            List<FichePaie> fichePaies = _context.FichePaies.Include("Employee").ToList();
            return View(fichePaies);
        }

        // GET: RhConges/Details/5
    }
}