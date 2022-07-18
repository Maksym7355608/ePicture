using ePicture.DAL.EF;
using ePicture.DAL.Entities;
using ePicture.DAL.Interfaces;
using System.Linq;
using System.Threading.Tasks;

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

        public async Task<User> LogInAsync(string username, string password)
        {
            return await Task.Run(() => LogIn(username, password));
        }

        public bool SignUp(User user)
        {
            if(user == null)
                return false;

            context.Users.Add(user);
            return true;
        }

        public async Task<bool> SignUpAsync(User user)
        {
            return await Task.Run(() => SignUp(user));
        }

        public bool UpdatePassword(int id, string password)
        {
            var user = context.Users.Find(id);

            if(user == null) return false;

            user.Password = password;
            context.Users.Update(user);
            return true;
        }

        public async Task<bool> UpdatePasswordAsync(int id, string password)
        {
            return await Task.Run(() => UpdatePassword(id, password));
        }
    }
}
