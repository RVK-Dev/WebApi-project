using Entity;
using Entity.Models;
using Repository;
using System.Text.Json;

namespace Service
{
    public class UserService : IUserService
    {
        IUserRepository repository;

        public UserService(IUserRepository UserRepository)
        {
            repository = UserRepository;
        }
        public async Task<User> GetUserById(int id)
        {

            return await repository.GetUserById(id);
        }
        public async Task<User> Post(User user)
        {
            return await repository.Post(user);
        }
        public async Task<User> Post(UserLogin userLogin)
        {
            return await repository.Post(userLogin);
        }
        public async Task Put(int id, User userToUpdate)
        {
          await repository.Put(id, userToUpdate);
        }

    }
}
