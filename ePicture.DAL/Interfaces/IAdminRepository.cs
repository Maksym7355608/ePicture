using ePicture.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ePicture.DAL.Interfaces
{
    public interface IAdminRepository
    {
        void DeleteUser(int userId);
        void DeletePicture(int pictureId);
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);

        Task DeleteUserAsync(int userId);
        Task DeletePictureAsync(int pictureId);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int id);
    }
}
