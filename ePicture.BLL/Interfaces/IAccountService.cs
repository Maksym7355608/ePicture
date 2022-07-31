using ePicture.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ePicture.BLL.Interfaces
{
    public interface IAccountService
    {
        void UpdateAccount(ArtistModel model);
        bool DeleteAccount(int accountId);
    }
}
