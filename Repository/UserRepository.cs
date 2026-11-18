using Entity;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;


namespace Repository
{
    public class UserRepository : IUserRepository
    {
        StoreExContext _dbContent;
        public UserRepository(StoreExContext StoreExContext)
        {
            _dbContent = StoreExContext;
        }

        //readonly string filePath = "D:\\לימודים שנה ב\\Api\\WebApi\\Repository\\file.txt";

        public async Task<User> GetUserById(int id)
        {
            return await _dbContent.Users.FindAsync(id);
        }

        public async Task<User> Post(User user)
        {
           await _dbContent.Users.AddAsync(user);
            await _dbContent.SaveChangesAsync();
            return user;
  
        }

        public async Task<User> Post(UserLogin userLogin)
        {
           
            return await _dbContent.Users.Where(user => user.Email == userLogin.Email && user.Password == userLogin.Password).FirstOrDefaultAsync();
                
          
        }

        public async Task Put(int id, User userToUpdate)
        {
            userToUpdate.Id = id;
            _dbContent.Users.Update(userToUpdate);
            await _dbContent.SaveChangesAsync();

        }
    }

}
