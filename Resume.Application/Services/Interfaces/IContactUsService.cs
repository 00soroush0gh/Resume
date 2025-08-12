using Resume.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interfaces;

public interface IContactUsService
{
    Task AddNewContactUsMessage(ContactUsDTO contactUsDTO);
}
