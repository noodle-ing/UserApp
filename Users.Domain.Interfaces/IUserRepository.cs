using Users.Domain.Core.Entities;

namespace Users.Domain.Interfaces;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAsync();
    Task<User> GetUserAsync(long id);
    Task<long> CreateUserAsync(User entity); // если метод асинхронный то по конвенции должен заканчаиваться на async
    Task<User?> UpdateUserAsync(User entity);
    Task<bool> DeleteAsync(long id);
}