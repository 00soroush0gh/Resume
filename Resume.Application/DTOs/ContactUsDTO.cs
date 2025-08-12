using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.DTOs;

public class ContactUsDTO
{
    #region properties

    public string FullName { get; set; } = null!;

    public string Mobile { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string Address { get; set; } = null!;

    #endregion
}
