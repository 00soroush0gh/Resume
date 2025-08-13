using Resume.Application.DTOs;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Entities;
using Resume.Domain.IRepository;

namespace Resume.Application.Services.Implement;

public class ContactUsService : IContactUsService
{
    private readonly IContactUsRepository _contactUsRepository;

    public ContactUsService(IContactUsRepository contactUsRepository)
    {
        _contactUsRepository = contactUsRepository;
    }

    public async Task AddNewContactUsMessage(ContactUsDTO contactUsDTO)
    {
        //Object Maping
        ContactUs contact = new ContactUs()
        {
            FullName = contactUsDTO.FullName,
            Message = contactUsDTO.Message,
            Mobile = contactUsDTO.Mobile
        };

        ContactUsLocation Location = new ContactUsLocation()
        {
            Address = contactUsDTO.Address,
        };

        //Add To The Data Base
        await _contactUsRepository.AddContactUsToTheDataBase(contact);
        await _contactUsRepository.AddLocationToTheDataBase(Location);
    }
}
