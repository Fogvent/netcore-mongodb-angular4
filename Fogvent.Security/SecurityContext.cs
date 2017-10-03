using System.Data.Entity;
using Fogvent.Models.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Fogvent.Security
{
    public class SecurityContext : IdentityDbContext<IdentityUser>
    {
        #region Constructor
        public SecurityContext() : base("SQLContext")
        {
            Configuration.LazyLoadingEnabled = false;
        }
        #endregion

        #region Entities
        ////public DbSet<User> Users { get; set; }
        ////public DbSet<Role> Roles { get; set; }
        //public DbSet<UserRole> UsersRoles { get; set; }
        //public DbSet<UserLogin> UserLogins { get; set; }
        //public DbSet<UserClaim> UserClaims { get; set; }

        #endregion

        #region Overriden Methods
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Database.CommandTimeout = 180;
        }

        #endregion

    }
}
