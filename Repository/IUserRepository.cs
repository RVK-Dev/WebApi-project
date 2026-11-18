using Entity;
using Entity.Models;

namespace Repository
{
    public interface IUserRepository
    {
        Task<User> GetUserById(int id);
        Task<User> Post(User user);
        Task<User> Post(UserLogin userLogin);
        Task Put(int id, User userToUpdate);
    }
}