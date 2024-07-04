namespace BookLibrary.Core.Repositories;
using BookLibrary.Core.Domain;

public interface IUserRepository
{
    Task<User> GetAsync(Guid id); 
    Task<User> GetAsync(string email);
    Task AddAsync(User user);
    Task UpdateAsync(User user);
    Task DeleteAsync(User user);         
}
