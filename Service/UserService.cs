using Entity;
using Repository;
using System.Text.Json;

namespace Service
{
    public class UserService
    {
        UserRepository repository = new UserRepository();
        public User GetUserById(int id)
        {
            
            return repository.GetUserById(id);
        }
        public User Post(User user)
        {
            return repository.Post(user);
        }
        public User Post( UserLogin userLogin)
        {
            return repository.Post(userLogin);
        }
         public void Put(int id, User userToUpdate)
        {
            repository.Put(id, userToUpdate);
        }
        
    }
}
