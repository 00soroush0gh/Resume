using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities;
using Resume.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Infrastructure.DataBaseContext;

public class OverAllDataBaseContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"\Resume\Resume.Infrastructure\DB\");
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Employer> Employers { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<ContactUs> ContactUs { get; set; }
    public DbSet<ContactUsLocation> locations { get; set; }
}
