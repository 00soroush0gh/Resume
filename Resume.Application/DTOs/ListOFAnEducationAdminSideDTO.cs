using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.DTOs;

public class ListOFAnEducationAdminSideDTO
{
    #region properties

    public int Id { get; set; }

    public string EducationTitle { get; set; } = null!;

    public string Duration { get; set; } = null!;

    #endregion
}
