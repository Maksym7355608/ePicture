using ePicture.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ePicture.DAL.EF
{
    public class ePictureContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Tag> Tags { get; set; }

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
