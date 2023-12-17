using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentWebApplication.Model;

namespace StudentWebApplication.Data
{
    public class StudentWebApplicationContext : DbContext
    {
        public StudentWebApplicationContext (DbContextOptions<StudentWebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<StudentWebApplication.Model.Student> Student { get; set; } = default!;

        public DbSet<StudentWebApplication.Model.Course>? Course { get; set; }
    }
}
