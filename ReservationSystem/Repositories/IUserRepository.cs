using ReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSystem.Repositories
{
   public interface IUserRepository
    {
        public Task<User> AddUserAsync(User user);
        public Task<IEnumerable<User>> GetAllUsersAsync();
        public Task<User> GetUserAsync(string id);
        public Task<User> UptadeUserAsync(User user);
        public Task<User> GetUserAsync(long id);
        public Task <Boolean> DeleteUserAsync(User user);
        
    }
}
