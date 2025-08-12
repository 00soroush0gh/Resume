using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Resume.Domain.Entities;

namespace Resume.Infrastructure.DataBaseContext;

public class ResumeDbContext : DbContext
{
    #region Ctor

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-JCN2C1I\\MSSQLSERVER2019;Initial Catalog=ResumeDaneshkar;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        base.OnConfiguring(optionsBuilder);
    }

    #endregion

    #region Db Sets

    public DbSet<Experience> Experiences { get; set; }

    public DbSet<MySkills> MySkills { get; set; }

    public DbSet<Education> Educations { get; set; }

    public DbSet<ContactUs> ContactUs { get; set; }

    public DbSet<ContactUsLocation> locations { get; set; }

    #endregion
}
