using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models;

namespace Resume.Infrastructure.DataBaseContext
{
    public class SkillDataBaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
            optionsBuilder.UseSqlite("");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<List<Skill>>? SubSkills { get; set; }
        
    }
}
