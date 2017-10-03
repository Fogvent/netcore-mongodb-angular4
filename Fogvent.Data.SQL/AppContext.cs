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

        public IDbSet<Event> Events { get; set; }
        public IDbSet<User> Users { get; set; }
        public IDbSet<Role> Roles { get; set; }
        public IDbSet<UserRole> UsersRoles { get; set; }
        public IDbSet<UserLogin> UserLogins { get; set; }
        public IDbSet<Agenda> Agendas { get; set; }
        public IDbSet<AgendaSpeaker> AgendaSpeakers { get; set; }
        public IDbSet<Category> Categories { get; set; }
        public IDbSet<Discussion> Discussions { get; set; }
        public IDbSet<EventAdmin> EventAdmins { get; set; }
        public IDbSet<EventApproval> EventApprovals { get; set; }
        public IDbSet<EventAttendee> EventAttendees { get; set; }
        public IDbSet<EventTopic> EventTopics { get; set; }
        public IDbSet<Notification> Notifications { get; set; }
        public IDbSet<NotificationUser> NotificationUsers { get; set; }
        public IDbSet<Speaker> Speakers { get; set; }
        public IDbSet<Ticket> Tickets { get; set; }
        public IDbSet<Topic> Topics { get; set; }
        public IDbSet<UserInterest> UserInterests { get; set; }

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
