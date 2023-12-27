using Microsoft.EntityFrameworkCore;
using Users.Domain.Core.Entities;

namespace Users.Infrastructure.Data;

public class UserRepository : IUserRepository
{
    private readonly UsersContext _context;

    public UserRepository(UsersContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<User>> GetAsync()
    {
        return await _context.Users.AsNoTracking().ToListAsync();
    }
    
    Task<long> IUserRepository.CreateUserAsync(User entity)
    {
        return CreateUserAsync(entity);
    }
     

    public async Task<User?> GetUserAsync(long id)
    {
        User? user = await _context.Users.FindAsync(id);
        return user;
    }

    public async Task<long> CreateUserAsync(User entity)
    {
        await _context.Users.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity.Id;
    }

    public async Task<User?> UpdateUserAsync(User entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> DeleteAsync(long id)
    {
        User? user = await _context.Users.FindAsync(id);
        if (user == null)
        {
            return false;
        }

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
        return true;
    }
}