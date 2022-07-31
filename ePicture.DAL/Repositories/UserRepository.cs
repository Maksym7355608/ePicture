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

        public void DeleteAccount(int id)
        {
            context.Users.Remove(GetUserById(id));
        }

        public async Task DeleteAccountAsync(int id)
        {
            context.Users.Remove(await GetUserByIdAsync(id));
        }

        public User GetUserById(int id)
        {
            return context.Users.Find(id);
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await context.Users.FindAsync(id);
        }

        public User LogIn(string email)
        {
            return context.Users.FirstOrDefault(user => user.Email.Equals(email));
        }

        public async Task<User> LogInAsync(string email)
        {
            return await Task.Run(() => LogIn(email));
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

        public void UpdatePassword(int id, string password)
        {
            var user = GetUserById(id);

            user.Password = password;
            context.Users.Update(user);
        }

        public async Task UpdatePasswordAsync(int id, string password)
        {
            var user = await GetUserByIdAsync(id);

            user.Password = password;
            context.Users.Update(user);
        }
    }
}
