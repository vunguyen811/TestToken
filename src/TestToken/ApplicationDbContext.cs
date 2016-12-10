using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestToken.Model;

namespace TestToken
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            //Database.Migrate();

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<RoleClaims>().ToTable("RoleClaims");
            modelBuilder.Entity<Roles>().ToTable("RoleClaims");
            modelBuilder.Entity<UserClaims>().ToTable("UserClaims");
            modelBuilder.Entity<UserLogins>().ToTable("UserLogins");
            modelBuilder.Entity<UserRoles>().ToTable("UserRoles");
            modelBuilder.Entity<UserTokens>().ToTable("UserTokens");
        }
    }
}
