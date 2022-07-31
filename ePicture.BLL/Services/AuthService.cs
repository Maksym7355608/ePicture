using AutoMapper;
using ePicture.BLL.DTO;
using ePicture.BLL.Infrastructure.JWT;
using ePicture.BLL.Interfaces;
using ePicture.DAL;
using ePicture.DAL.Entities;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace ePicture.BLL.Services
{
    public class AuthService : IAuthService
    {
        private IMapper mapper;
        private IUnitOfWork context;
        IOptions<AuthOptions> authOptions;

        public AuthService(IUnitOfWork context, IMapper mapper, IOptions<AuthOptions> authOptions)
        {
            this.context = context;
            this.mapper = mapper;
            this.authOptions = authOptions;
            AddAdmin();
        }

        private string Encrypt(string password)
        {
            var data = Encoding.Unicode.GetBytes(password);
            var encrypted = ProtectedData.Protect(data, null, DataProtectionScope.LocalMachine);
            return Convert.ToBase64String(encrypted);
        }

        private string Decrypt(string password)
        {
            var data = Convert.FromBase64String(password);
            var decrypted = ProtectedData.Unprotect(data, null, DataProtectionScope.LocalMachine);
            return Encoding.Unicode.GetString(decrypted);
        }

        private string GetToken(UserModel user)
        {
            var authParams = authOptions.Value;
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = authParams.GetSymmetricSecurityKey();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim(ClaimTypes.Role, user.Role)
                }),
                Expires = DateTime.UtcNow.AddSeconds(authParams.TokenLifeTime),
                SigningCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }


        public string LogIn(string email, string password)
        {
            var user = context.User.LogIn(email);
            if (user == null)
                throw new Exception();
            else
                if (Decrypt(user.Password) == password)
                    return GetToken(mapper.Map<UserModel>(user));
                else
                    throw new Exception();
        }

        public bool SignUp(UserModel model)
        {
            model.Role = Roles.Artist;
            return context.User.SignUp(mapper.Map<User>(model));
        }

        private void AddAdmin()
        {
            if ((context.User.GetUserById(1)) == null)
                context.User.SignUp(new User
                {
                    Id = 1,
                    Name = "Admin",
                    Surname = "",
                    Email = "admin.admin@administrators.eu",
                    Password = Encrypt("ItheBestAdmin"),
                    Role = Roles.Admin
                });
        }
    }
}
