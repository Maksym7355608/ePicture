using ePicture.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ePicture.DAL.Interfaces
{
    public interface IAdminRepository
    {
        void DeleteUser(int userId);
        void DeletePicture(int pictureId);
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);

    }
}
