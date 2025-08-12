using Resume.Domain.Entities;
using Resume.Domain.IRepository;
using Resume.Infrastructure.DataBaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Infrastructure.Repository;

public class ContactUsRepository : IContactUsRepository
{
    #region Ctor

    private readonly ResumeDbContext _context;

    public ContactUsRepository(ResumeDbContext Context)
    {
        _context = Context;
    }

    #endregion

    public async Task AddContactUsToTheDataBase(ContactUs contact)
    {
        await _context.ContactUs.AddAsync(contact);
        await _context.SaveChangesAsync();
    }

    public async Task AddLocationToTheDataBase(ContactUsLocation location)
    {
        await _context.locations.AddAsync(location);
        await _context.SaveChangesAsync();
    }
}
