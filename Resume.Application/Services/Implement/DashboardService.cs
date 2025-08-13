using Resume.Application.DTOs;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implement;

public class DashboardService : IDashboardService
{
    #region Ctor

    private readonly IEducationService _educationService;
    private readonly IExperienceService _experienceService;
    private readonly IMySkillService _mySkillService;

    public DashboardService(IEducationService educationService,
                          IExperienceService experienceService,
                          IMySkillService mySkillService)
    {
        _educationService = educationService;
        _experienceService = experienceService;
        _mySkillService = mySkillService;
    }

    public async Task<HomeIndexModelDTO> FillDashboardModel()
    {
        #region My Skills 

        List<MySkills> mySkills = _mySkillService.GetListOfMySkills();

        #endregion

        #region Educations

        List<Education> educations = _educationService.GetListOFEducations();

        #endregion

        #region Experience

        List<Experience> experiences = _experienceService.GetListOfExperience();

        #endregion

        #region Fill Instance Model 

        HomeIndexModelDTO model = new HomeIndexModelDTO();

        model.Experiences = experiences;
        model.Educations = educations;
        model.MySkills = mySkills;

        #endregion

        return model;
    }

    #endregion
}
