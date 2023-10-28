using TaskManagerPlus.Domain.Entities;

namespace TaskManagerPlus.Domain.Services
{
    public interface IUserService
    {
        public void CreateUser(User user);
        public User GetUserById(int userId);
    }
}
