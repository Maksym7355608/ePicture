using ePicture.DAL.EF;
using ePicture.DAL.Entities;
using ePicture.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public void DeleteUser(int userId)
        {
            var user = context.Users.Find(userId);
            context.Users.Remove(user);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return context.Users;
        }

        public User GetUserById(int id)
        {
            return context.Users.Find(id);
        }
    }
}
