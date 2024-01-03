using Core.CleanArchitecture.Domain.Entities;
using Core.CleanArchitecture.Domain.Interfaces;
using Infrastructure.CleanArchitecture.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.CleanArchitecture.Persistance.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {}

        public async Task<User> GetByEmail(string email, CancellationToken cancellationToken)
        {
            return await Context.Users.FirstOrDefaultAsync(u => u.Email.Equals(email), cancellationToken);
        }
    }
}