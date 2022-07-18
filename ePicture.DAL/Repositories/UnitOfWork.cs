using ePicture.DAL.EF;
using ePicture.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ePicture.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ePictureContext context;
        private UserRepository userRepository;
        private AdminRepository adminRepository;
        private PictureRepository pictureRepository;
        public UnitOfWork(ePictureContext context)
        {
            this.context = context;
        }

        public IUserRepository User
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(context);
                return userRepository;
            }
        }
        public IAdminRepository Admin
        {
            get
            {
                if (adminRepository == null)
                    adminRepository = new AdminRepository(context);
                return adminRepository;
            }
        }
        public IPictureRepository Picture
        {
            get
            {
                if (pictureRepository == null)
                    pictureRepository = new PictureRepository(context);
                return pictureRepository;
            }
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
