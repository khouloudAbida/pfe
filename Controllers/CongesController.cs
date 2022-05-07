using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeApplication.Models;
using Microsoft.AspNetCore.Http;

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
        public async Task<IActionResult> Index()
        {
            int employeID = int.Parse(HttpContext.Session.GetString("EmployeeID"));
            var appDbContext = _context.Conges.Where(c=>c.EmployeeID == employeID).Include(c => c.Employee).Include(c=>c.TypeConge);
            return View(await appDbContext.ToListAsync());
        }

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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,DU,AU,Notes,EmployeeID,TypeCongeID")] Conge conge)
        {

            if (ModelState.IsValid)
            {
                List<TypeConge> conges = _context.TypeConges.ToList();
                ViewBag.Types = new SelectList(conges, "ID", "Type");
                if (conge.DU<DateTime.Now)
                {
                    ViewBag.Error = "Date Début doits etre supperieur ou egale au date du Jour.";
                    return View();
                }
                if(conge.DU> conge.AU)
                {
                    ViewBag.Error = "Date Fin doit etre supperieur au date début. ";
                    return View();
                }
                conge.EmployeeID = int.Parse(HttpContext.Session.GetString("EmployeeID"));
                conge.status = -1;
                _context.Add(conge);
                await _context.SaveChangesAsync();
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
                        ViewBag.Error = "Date Début doits etre supperieur ou egale au date du Jour.";
                        return View();
                    }
                    if (conge.DU > conge.AU)
                    {
                        ViewBag.Error = "Date Fin doit etre supperieur au date début. ";
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
    }
}
