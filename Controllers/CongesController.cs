using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using EmployeeApplication.Securirty;

namespace EmployeeApplication.Controllers
{
    public class CongesController : Controller
    {
        private readonly AppDbContext _context;


        public CongesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Conges
       /// [EmployeeAuth]
        public async Task<IActionResult> Index()
        {
            int employeID = int.Parse(HttpContext.Session.GetString("EmployeeID"));
            var appDbContext = _context.Conges.Where(c=>c.EmployeeID == employeID).Include(c => c.Employee).Include(c=>c.TypeConge);
            return View(await appDbContext.ToListAsync());
        }
        //[EmployeeAuth]
        // GET: Conges/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conge = await _context.Conges
                .Include(c => c.Employee)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (conge == null)
            {
                return NotFound();
            }

            return View(conge);
        }

        // GET: Conges/Create
        [EmployeeAuth]
        public IActionResult Create()
        {
            List<TypeConge> conges = _context.TypeConges.ToList();
            ViewBag.Types = new SelectList(conges, "ID", "Type");
            return View();
        }

        // POST: Conges/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        // [ValidateAntiForgeryToken]
        [EmployeeAuth]
        public async Task<IActionResult> Create( Conge conge)
        {
            

            if (ModelState.IsValid)
            {
                JoursFerie[] joursFeries = _context.joursFeries.Where((j) => (( j.Day <= conge.DU.Day && (j.Day + j.NbJours) >= conge.DU.Day) || (j.Day <= conge.AU.Day && (j.Day + j.NbJours) >= conge.AU.Day)) &&j.Month == conge.DU.Month && j.Annee == conge.DU.Year).ToArray();
                if(joursFeries.Length>0)
                {
                    ViewBag.Error = "La date Debut doit être supérieure ou égale à la date du jour.";
                    return View();
                }
                List<TypeConge> conges = _context.TypeConges.ToList();
                ViewBag.Types = new SelectList(conges, "ID", "Type");
                if (conge.DU<DateTime.Now)
                {
                    ViewBag.Error =" La date fin doit être supérieure ou égale à la date du jour.";
                    return View();
                }
                if(conge.DU> conge.AU)
                {
                    ViewBag.Error = "Date Fin doit être supérieure au date début. ";
                    return View();
                }
                //relation
                conge.EmployeeID = int.Parse(HttpContext.Session.GetString("EmployeeID"));
                conge.status = -1;
                double nbHeure=0;
                if(conge.DU.ToString("yyyy-MM-dd").Equals(conge.AU.ToString("yyyy-MM-dd")) )
                {
                    nbHeure += (conge.AU - conge.DU).TotalHours;
                    if (nbHeure > 8)
                        nbHeure = 8;
                }
                else
                {
                    nbHeure +=(conge.DU - new DateTime(conge.DU.Year, conge.DU.Month, conge.DU.Day, 8, 00, 0)).TotalHours;

                    nbHeure += (((conge.AU.Date.AddDays(-1) - conge.DU.Date.AddDays(1)).TotalDays+1) *8);
                    nbHeure +=  (conge.AU - new DateTime(conge.AU.Year, conge.AU.Month, conge.AU.Day, 8, 00, 0)).TotalHours;
                }
                conge.NbHours = (int)nbHeure;
                _context.Add(conge);
                try
                {
                    await _context.SaveChangesAsync();
                }catch(Exception ex)
                {

                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "IdEmployee", "Adresse", conge.EmployeeID);
            return View(conge);
        }

        // GET: Conges/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conge = await _context.Conges.FindAsync(id);
            if (conge == null)
            {
                return NotFound();
            }
            List<TypeConge> conges = _context.TypeConges.ToList();
            ViewBag.Types = new SelectList(conges, "ID", "Type");
            return View(conge);
        }

        // POST: Conges/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,DU,AU,Notes,EmployeeID,TypeCongeID,status")] Conge conge)
        {
            if (id != conge.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                List<TypeConge> conges = _context.TypeConges.ToList();
                ViewBag.Types = new SelectList(conges, "ID", "Type");
                try
                {
                    if (conge.DU < DateTime.Now)
                    {
                        ViewBag.Error = "Date Debut doit être supérieure ou égale au date du Jour.";
                        return View();
                    }
                    if (conge.DU > conge.AU)
                    {
                        ViewBag.Error = "Date Fin doit être supérieure au date début.  ";
                        return View();
                    }
                    conge.EmployeeID = int.Parse(HttpContext.Session.GetString("EmployeeID"));

                    _context.Update(conge);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CongeExists(conge.ID))
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
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "IdEmployee", "Adresse", conge.EmployeeID);
            return View(conge);
        }



        public async Task<IActionResult> Update( Conge conge)
        {
            

            if (ModelState.IsValid)
            {
                 JoursFerie[] joursFeries = _context.joursFeries.Where((j) => ((j.Day <= conge.DU.Day && (j.Day + j.NbJours) >= conge.DU.Day) || (j.Day <= conge.AU.Day && (j.Day + j.NbJours) >= conge.AU.Day)) && j.Month == conge.DU.Month && j.Annee == conge.DU.Year).ToArray();
                if (joursFeries.Length > 0)
                {
                    ViewBag.Error = "Début ou Fin du congée est un jours férier";
                    return View();
                }
                List<TypeConge> conges = _context.TypeConges.ToList();
                ViewBag.Types = new SelectList(conges, "ID", "Type");
                if (conge.DU < DateTime.Now)
                {
                    ViewBag.Error = "Date Debut doit être supérieure ou égale au date du Jour.";
                    return View();
                }
                if (conge.DU > conge.AU)
                {
                    ViewBag.Error = "Date Fin doit être supérieure au date début.";
                    return View();
                }
                conge.EmployeeID = int.Parse(HttpContext.Session.GetString("EmployeeID"));
                conge.status = -1;
                double nbHeure = 0;
                if (conge.DU.ToString("yyyy-MM-dd").Equals(conge.AU.ToString("yyyy-MM-dd")))
                {
                    nbHeure += (conge.AU - conge.DU).TotalHours;
                    if (nbHeure > 8)
                        nbHeure = 8;
                }
                else
                {
                    nbHeure += 8 - (conge.DU - new DateTime(conge.DU.Year, conge.DU.Month, conge.DU.Day, 8, 00, 0)).TotalHours;

                    nbHeure += (((conge.AU.Date.AddDays(-1) - conge.DU.Date.AddDays(1)).TotalDays + 1) * 8);
                    nbHeure += 8 - (conge.AU - new DateTime(conge.AU.Year, conge.AU.Month, conge.AU.Day, 8, 00, 0)).TotalHours;
                }
                conge.NbHours = (int)nbHeure; _context.Update(conge);
                    await _context.SaveChangesAsync();
                }
                
              
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "IdEmployee", "Adresse", conge.EmployeeID);
            return View("Calendar");
        }

        // GET: Conges/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conge = await _context.Conges
                .Include(c => c.Employee)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (conge == null)
            {
                return NotFound();
            }

            return View(conge);
        }

        // POST: Conges/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var conge = await _context.Conges.FindAsync(id);
            _context.Conges.Remove(conge);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CongeExists(int id)
        {
            return _context.Conges.Any(e => e.ID == id);
        }

        public ActionResult Calendar()
        {
            List<TypeConge> conges = _context.TypeConges.ToList();
            ViewBag.Types = new SelectList(conges, "ID", "Type");
            return View();
        }
        public ActionResult RhCalander()
        {
            return View();
        }

        public System.Web.Mvc.JsonResult GetEvents()
        {

            List<Conge> events = _context.Conges.Include(c => c.Employee).Include(c => c.TypeConge).ToList();
                return new System.Web.Mvc.JsonResult { Data = events, JsonRequestBehavior = System.Web.Mvc.JsonRequestBehavior.AllowGet };
            
        }

        [HttpPost]
        public string ChangeStatus(Conge conge)
        {
            Conge c = _context.Conges.Find(conge.ID);
            c.status = conge.status;
            _context.Conges.Update(c);
            _context.SaveChanges();
            return "ok";
        }


    }
}
