using Resume.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.IRepository;

public interface IEducationRepository
{
    //GetListOFEducations
    List<Education> GetListOFEducations();

    Task AddEducationToDataBase(Education education);

    Task<Education> GetAnEducationByIdAsync(int educationId);

    Task EditAnEducation(Education education);

    Task DeleteAnEducation(Education education);
}
