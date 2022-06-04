

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeApplication.Models;

namespace EmployeeApplication.Models
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Conge> Conges { get; set; }

        public DbSet<TypeConge> TypeConges { get; set; }

        public DbSet<JoursFerie> joursFeries { get; set; }
        public DbSet<Contrat> Contrats { get; set; }


        public DbSet<FichePaie> FichePaies { get; set; }


    }
}