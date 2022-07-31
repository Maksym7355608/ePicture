using ePicture.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ePicture.BLL.Interfaces
{
    public interface IAuthService
    {
        string LogIn(string email, string password);
        bool SignUp(UserModel model);
    }
}
