using ePicture.DAL.Entities;
using System.Threading.Tasks;

namespace ePicture.DAL.Interfaces
{
    public interface IUserRepository
    {
        bool SignUp(User user);
        User LogIn(string email);
        void UpdatePassword(int id, string password);
        User GetUserById(int id);
        void DeleteAccount(int id);

        Task UpdatePasswordAsync(int id, string password);
        Task<bool> SignUpAsync(User user);
        Task<User> LogInAsync(string email);
        Task<User> GetUserByIdAsync(int id);
        Task DeleteAccountAsync(int id);

    }
}
