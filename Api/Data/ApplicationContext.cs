using Api.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class ApplicationContext : IdentityDbContext<UserEntity>
    {
      

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<FileEntity> Materials { get; set; }
        public DbSet<UserEntity> AppUsers {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>(x => x.HasData
            (
                new IdentityRole { Id = "1", Name ="Admin " , NormalizedName = "ADMIN"},
                new IdentityRole { Id = "2", Name ="User " , NormalizedName = "USER"}
            ));
        }

    }

}