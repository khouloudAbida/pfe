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
                _context.SaveChanges();
            }
            var appDbContext = _context.Conges.Include(c => c.Employee).Include(c => c.TypeConge);
            return View("index",await appDbContext.ToListAsync());

        }

        // GET: RhConges/Details/5
    }
}