using Resume.Application;
using Resume.Infrastructure.DataBaseContext;

namespace Resume.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private readonly ResumeDbContext _context;
    public UnitOfWork(ResumeDbContext context)
    {
        _context = context;
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }
}
