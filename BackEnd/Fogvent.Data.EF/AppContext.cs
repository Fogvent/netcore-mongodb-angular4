using Microsoft.EntityFrameworkCore;

namespace Fogvent.Data.EF
{
    public class AppContext : DbContext
    {
        #region Construcor
        public AppContext(DbContextOptions<AppContext> options) : base(options) { }
        #endregion

        #region Entities

        public DbSet<Entities.Event> Events { get; set; }
        public DbSet<Entities.User> Users { get; set; }
        public DbSet<Entities.Role> Roles { get; set; }
        public DbSet<Entities.UserRole> UsersRoles { get; set; }
        public DbSet<Entities.UserLogin> UserLogins { get; set; }
        public DbSet<Entities.Agenda> Agendas { get; set; }
        public DbSet<Entities.AgendaSpeaker> AgendaSpeakers { get; set; }
        public DbSet<Entities.Category> Categories { get; set; }
        public DbSet<Entities.Discussion> Discussions { get; set; }
        public DbSet<Entities.EventAdmin> EventAdmins { get; set; }
        public DbSet<Entities.EventApproval> EventApprovals { get; set; }
        public DbSet<Entities.EventAttendee> EventAttendees { get; set; }
        public DbSet<Entities.EventTopic> EventTopics { get; set; }
        public DbSet<Entities.Notification> Notifications { get; set; }
        public DbSet<Entities.NotificationUser> NotificationUsers { get; set; }
        public DbSet<Entities.Speaker> Speakers { get; set; }
        public DbSet<Entities.Ticket> Tickets { get; set; }
        public DbSet<Entities.Topic> Topics { get; set; }
        public DbSet<Entities.UserInterest> UserInterests { get; set; }

        #endregion

        #region Overriden Methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                Database.SetCommandTimeout(180);
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Fogvent;Integrated Security=True;");
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
