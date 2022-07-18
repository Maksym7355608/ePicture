using ePicture.DAL.EF;
using ePicture.DAL.Entities;
using ePicture.DAL.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ePicture.DAL.Repositories
{
    internal class AdminRepository : IAdminRepository
    {
        private ePictureContext context;

        public AdminRepository(ePictureContext context)
        {
            this.context = context;
        }

        public void DeletePicture(int pictureId)
        {
            var picture = context.Pictures.Find(pictureId);
            context.Pictures.Remove(picture);
        }

        public async Task DeletePictureAsync(int pictureId)
        {
            var picture = await context.Pictures.FindAsync(pictureId);
            context.Pictures.Remove(picture);
        }

        public void DeleteUser(int userId)
        {
            var user = context.Users.Find(userId);
            context.Users.Remove(user);
        }

        public async Task DeleteUserAsync(int userId)
        {
            var user = await context.Users.FindAsync(userId);
            context.Users.Remove(user);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return context.Users;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await Task.Run(() => GetAllUsers());
        }

        public User GetUserById(int id)
        {
            return context.Users.Find(id);
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await context.Users.FindAsync(id);
        }
    }
}
