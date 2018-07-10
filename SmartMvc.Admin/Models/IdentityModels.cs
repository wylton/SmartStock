using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SmartMvc.Admin.Models
{
    public class ApplicationUser : IdentityUser
    {

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("SmartEntities", throwIfV1Schema: false)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUser>()
                .ToTable("User")
                .Property(p => p.Id)
                .HasColumnName("Id");

            modelBuilder.Entity<ApplicationUser>()
                .ToTable("User")
                .Property(p => p.Id)
                .HasColumnName("Id");

            modelBuilder.Entity<IdentityUserRole>()
                .ToTable("UserRole");

            modelBuilder.Entity<IdentityUserLogin>()
                .ToTable("Logins");

            modelBuilder.Entity<IdentityUserClaim>()
                .ToTable("Claims");

            modelBuilder.Entity<IdentityRole>()
                .ToTable("Roles");
        }


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}