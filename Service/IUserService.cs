using Entity;

namespace Service
{
    public interface IUserService
    {
        User GetUserById(int id);
        User Post(User user);
        User Post(UserLogin userLogin);
        void Put(int id, User userToUpdate);
    }
}