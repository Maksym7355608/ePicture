using ePicture.DAL.Entities;
using System.Threading.Tasks;

namespace ePicture.DAL.Interfaces
{
    public interface IUserRepository
    {
        bool SignUp(User user);
        User LogIn(string username, string password);
        bool UpdatePassword(int id, string password);

        Task<bool> UpdatePasswordAsync(int id, string password);
        Task<bool> SignUpAsync(User user);
        Task<User> LogInAsync(string username, string password);
    }
}
