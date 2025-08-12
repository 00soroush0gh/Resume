using Resume.Domain.Entities;
using Resume.Domain.IRepository;
using Resume.Infrastructure.DataBaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Infrastructure.Repository;

public class ExperienceRepository : IExperienceRepository
{
    #region Ctor

    private readonly ResumeDbContext _context;

    public ExperienceRepository(ResumeDbContext context)
    {
        _context = context;
    }

    #endregion

    public List<Experience> GetListOfExperience()
    {
        return _context.Experiences.ToList();
    }
}
