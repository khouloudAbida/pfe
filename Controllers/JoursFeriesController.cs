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
    public class JoursFeriesController : Controller
    {
        private readonly AppDbContext _context;

        public JoursFeriesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: JoursFeries
        public async Task<IActionResult> Index()
        {
            return View(await _context.joursFeries.OrderBy(j=>j.Annee).OrderBy(j=>j.Day).ToListAsync());
        }

        // GET: JoursFeries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joursFerie = await _context.joursFeries
                .FirstOrDefaultAsync(m => m.ID == id);
            if (joursFerie == null)
            {
                return NotFound();
            }

            return View(joursFerie);
        }

        // GET: JoursFeries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JoursFeries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Month,Day,NbJours,Annee,ISAllYear")] JoursFerie joursFerie)
        {
            if (ModelState.IsValid)
            {
                int nbYear = 0;
                DateTime date = new DateTime(joursFerie.Annee, joursFerie.Month, joursFerie.Day);

                while (nbYear < 20)
                {
                    JoursFerie j = new JoursFerie();
                    j.Annee = date.Year;
                    j.Month = date.Month;
                    j.Day = date.Day;
                    j.ISAllYear = joursFerie.ISAllYear;
                    j.NbJours = joursFerie.NbJours;
                    _context.Add(j);
                    await _context.SaveChangesAsync();
                    if (joursFerie.ISAllYear == 1)
                    {
                        nbYear++;
                        date = date.AddYears(1);
                    }
                    else
                        nbYear = 20;
                    
                }
                return RedirectToAction(nameof(Index));
            }
            return View(joursFerie);
        }

        // GET: JoursFeries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joursFerie = await _context.joursFeries.FindAsync(id);
            if (joursFerie == null)
            {
                return NotFound();
            }
            return View(joursFerie);
        }

        // POST: JoursFeries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Month,Day,NbJours,Annee,ISAllYear")] JoursFerie joursFerie)
        {
            if (id != joursFerie.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    int nbYear = 0;
                    
                    JoursFerie laststate = _context.joursFeries.Find(joursFerie.ID);
                    List<JoursFerie> joursFeries = _context.joursFeries.Where(j1 => laststate.Month == j1.Month && j1.Day == laststate.Day).ToList();


                    if (laststate.ISAllYear == 0 && joursFerie.ISAllYear == 1)
                    {
                        DateTime date = new DateTime(joursFerie.Annee+1, joursFerie.Month, joursFerie.Day);

                        while (nbYear < 20)
                        {
                            JoursFerie j = new JoursFerie();
                            j.Annee = date.Year;
                            j.Month = date.Month;
                            j.Day = date.Day;
                            j.ISAllYear = joursFerie.ISAllYear;
                            j.NbJours = joursFerie.NbJours;
                            _context.Add(j);
                            await _context.SaveChangesAsync();

                            nbYear++;
                            date = date.AddYears(1);


                        }
                    }
                         if (laststate.ISAllYear == 1 &&joursFerie.ISAllYear == 1 )
                        {
                            foreach (JoursFerie ferie in joursFeries)
                            {
                                ferie.Day = joursFerie.Day;
                                ferie.Month = joursFerie.Month;
                                _context.Update(ferie);
                            }
                            nbYear++;

                        }
                        if(laststate.ISAllYear==1 && joursFerie.ISAllYear==0)
                        { 
                            foreach (JoursFerie ferie in joursFeries)
                            {
                                ferie.Day = joursFerie.Day;
                                ferie.Month = joursFerie.Month;
                                _context.Remove(ferie);
                            }

                           
                        }

                    _context.Entry<JoursFerie>(laststate).State = EntityState.Detached;
                    _context.Update(joursFerie);
                        await _context.SaveChangesAsync();
                    }
                
            
                catch (DbUpdateConcurrencyException)
                {
                    if (!JoursFerieExists(joursFerie.ID))
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
            return View(joursFerie);
        }

        // GET: JoursFeries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joursFerie = await _context.joursFeries
                .FirstOrDefaultAsync(m => m.ID == id);
            if (joursFerie == null)
            {
                return NotFound();
            }

            return View(joursFerie);
        }

        // POST: JoursFeries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var joursFerie = await _context.joursFeries.FindAsync(id);
            _context.joursFeries.Remove(joursFerie);
            List<JoursFerie> joursFeries = _context.joursFeries.Where(j1 => joursFerie.Month == j1.Month && j1.Day == joursFerie.Day).ToList();

            if ( joursFerie.ISAllYear == 1)
            {
                foreach (JoursFerie ferie in joursFeries)
                {
                    ferie.Day = joursFerie.Day;
                    ferie.Month = joursFerie.Month;
                    _context.Remove(ferie);
                }
                await _context.SaveChangesAsync();

            }
            return RedirectToAction(nameof(Index));
        }

        private bool JoursFerieExists(int id)
        {
            return _context.joursFeries.Any(e => e.ID == id);
        }
    }
}
