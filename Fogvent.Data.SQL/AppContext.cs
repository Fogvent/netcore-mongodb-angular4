using System.Data.Entity;
using Fogvent.Models.Entities;


namespace Fogvent.Data.SQL
{
    public class AppContext : DbContext
    {
        #region Constructor
        public AppContext() : base("SQLContext")
        {
            Configuration.LazyLoadingEnabled = false;
        }
        #endregion


        #region Entities
        public DbSet<Event> Events { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
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
