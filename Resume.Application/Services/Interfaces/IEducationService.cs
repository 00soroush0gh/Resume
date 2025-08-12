using Resume.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interfaces;

public interface IEducationService
{
    //GetListOFEducations
    List<Education> GetListOFEducations();

    //Get List Of An Education For Show in Admin Panel 
    List<ListOFAnEducationAdminSideDTO> GetListOfAnEducationForShowinAdminPanel();

    Task AddEducationToDataBase(CreateAnEducationAdminSideDTO model);

    Task<Education> GetAnEducationByIdAsync(int educationId);

    Task EditAnEducation(Education education);

    Task DeleteAnEducation(Education education);
}
