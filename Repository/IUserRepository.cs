using Entity;

namespace Repository
{
    public interface IUserRepository
    {
        User GetUserById(int id);
        User Post(User user);
        User Post(UserLogin userLogin);
        void Put(int id, User userToUpdate);
    }
}