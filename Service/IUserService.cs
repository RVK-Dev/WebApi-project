using Entity;
using Entity.Models;

namespace Service
{
    public interface IUserService
    {
        Task<User> GetUserById(int id);
        Task<User> Post(User user);
        Task<User> Post(UserLogin userLogin);
        Task Put(int id, User userToUpdate);
    }
}