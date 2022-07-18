using ePicture.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ePicture.DAL.EF
{
    internal class ePictureContext : DbContext
    {
        public new DbSet<User> Users { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public ePictureContext()
        {

        }

        public ePictureContext(DbContextOptions<ePictureContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
