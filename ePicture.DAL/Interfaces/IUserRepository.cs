using ePicture.DAL.Entities;

namespace ePicture.DAL.Interfaces
{
    public interface IUserRepository
    {
        bool SignUp(User user);
        User LogIn(string username, string password);
        bool UpdatePassword(int id, string password);
    }
}
