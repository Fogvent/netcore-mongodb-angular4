using System.Data.Entity;
using Fogvent.Models.Entities;
using Microsoft.AspNet.Identity.EntityFramework;


namespace Fogvent.Data.SQL
{
    public class AppContext : IdentityDbContext<User>
    {
        #region Constructor
        public AppContext() : base("SQLContext")
        {
            Configuration.LazyLoadingEnabled = false;
        }
        #endregion

        //TODO
        #region Entities
        public DbSet<Event> Events { get; set; }
        public override IDbSet<User> Users { get; set; }
        public override IDbSet<IdentityRole> Roles { get; set; }
        public DbSet<UserRole> UsersRoles { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<UserClaim> UserClaims { get; set; }

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
