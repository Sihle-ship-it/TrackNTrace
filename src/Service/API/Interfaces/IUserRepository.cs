using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {

        User GetUserByEmail(string email);
        void Register(User user);
        User Login(string email, string password);

    }
}
