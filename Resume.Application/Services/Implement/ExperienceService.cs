using Resume.Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implement;

public class ExperienceService : IExperienceService
{
    #region Ctor

    private readonly IExperienceRepository _experienceRepository;

    public ExperienceService(IExperienceRepository experienceRepository)
    {
        _experienceRepository = experienceRepository;
    }

    #endregion

    public List<Experience> GetListOfExperience()
    {
        return _experienceRepository.GetListOfExperience();
    }
}
