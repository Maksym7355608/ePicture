using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using ePicture.DAL;
using ePicture.DAL.EF;
using Microsoft.EntityFrameworkCore;
using ePicture.DAL.Repositories;

namespace ePicture.BLL.DI
{
    public static class DependencyInjections
    {
        public static void AddDependencyDAL(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ePictureContext>(option => option.UseSqlServer(connectionString));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
