using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserService.Api.Extensions;

namespace UserService.Api.Entities
{
    public class UserServiceDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, long>
    {
        public UserServiceDbContext(DbContextOptions<UserServiceDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.UseSnakeCase();

            /*builder.Entity<ApplicationUser>()
                .Property(u => u.Id)
                .HasMaxLength(450);

            builder.Entity<IdentityRole>()
                .Property(r => r.Id)
                .HasMaxLength(450);

            // These properties are also used in keys
            builder.Entity<IdentityUserLogin<string>>()
                .Property(l => l.LoginProvider)
                .HasMaxLength(450);

            builder.Entity<IdentityUserLogin<string>>()
                .Property(l => l.ProviderKey)
                .HasMaxLength(450);

            builder.Entity<IdentityUserToken<string>>()
                .Property(t => t.LoginProvider)
                .HasMaxLength(450);

            builder.Entity<IdentityUserToken<string>>()
                .Property(t => t.Name)
                .HasMaxLength(450); */
        }
    }
}