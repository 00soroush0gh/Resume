using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.Entities;

public class ContactUs
{
    #region properties

    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string Mobile { get; set; } = null!;

    public string Message { get; set; } =null!;

    public DateTime CreateDate { get; set; } = DateTime.Now;

    public bool IsSeenByAdmin { get; set; }

    #endregion
}
