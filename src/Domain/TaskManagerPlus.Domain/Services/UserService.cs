using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerPlus.Domain.Entities;

namespace TaskManagerPlus.Domain.Services
{
    public class UserService : IUserService
    {
        private List<User> _users;
        public UserService()
        {
            _users = new List<User>();
        }

        public void CreateUser(User user)
        {
            if (user != null && !string.IsNullOrWhiteSpace(user.FirstName) && !string.IsNullOrWhiteSpace(user.LastName))
            {
                user.Id = GenerateUserId();
                _users.Add(user);
            }
            else
            {
                throw new ArgumentException("Invalid user data. Both first name and last name are required.");
            }
        }

        public User GetUserById(int userId)
        {
            return _users.Find(u => u.Id == userId);
        }

        private int GenerateUserId()
        {
            // This is a simple placeholder for generating unique user IDs.
            // In a real application, you would use a more robust mechanism (e.g., database-generated IDs).
            return _users.Count + 1;
        }
    }
}
