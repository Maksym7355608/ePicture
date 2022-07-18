using ePicture.DAL.Entities;

namespace ePicture.DAL.Interfaces
{
    public interface IUserRepository
    {
        bool SignIn(User user);
        bool LogIn(string username, string password);
        bool UpdatePassword(int id, string password);
    }
}
