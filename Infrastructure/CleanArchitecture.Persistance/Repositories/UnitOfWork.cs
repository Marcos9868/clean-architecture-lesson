using Core.CleanArchitecture.Domain.Interfaces;
using Infrastructure.CleanArchitecture.Persistance.Context;

namespace Infrastructure.CleanArchitecture.Persistance.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task Commit(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}