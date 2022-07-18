using System;
using System.Threading.Tasks;
using ePicture.DAL.Interfaces;

namespace ePicture.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository User { get; }
        IAdminRepository Admin { get; }
        IPictureRepository Picture { get; }

        void Save();
        Task SaveAsync();
    }
}
