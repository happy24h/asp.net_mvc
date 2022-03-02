using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Assignment2.Models;
using Microsoft.AspNetCore.Identity;

namespace Assignment2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Assignment2.Models.Semester> Semester { get; set; }
        public DbSet<Assignment2.Models.Student> Student { get; set; }
        public DbSet<Assignment2.Models.Subject> Subject { get; set; }
        public DbSet<Assignment2.Models.Test> Test { get; set; }
        public DbSet<Assignment2.Models.ApplicationUser> ApplicationUser { get; set; }
    }
}
