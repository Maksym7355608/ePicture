using ePicture.DAL.EF;
using ePicture.DAL.Entities;
using ePicture.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ePicture.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private ePictureContext context;

        public UserRepository(ePictureContext context)
        {
            this.context = context;
        }

        public User LogIn(string username, string password)
        {
            return context.Users.FirstOrDefault(user => user.Email.Equals(username) && user.Password.Equals(password));
        }

        public bool SignUp(User user)
        {
            if(user == null)
                return false;

            context.Users.Add(user);
            return true;
        }

        public bool UpdatePassword(int id, string password)
        {
            var user = context.Users.Find(id);

            if(user == null) return false;

            user.Password = password;
            context.Users.Update(user);
            return true;
        }
    }
}
