using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            Roles = new HashSet<Role>();
            Logins = new HashSet<UserLogin>();
            EventAttendees = new HashSet<EventAttendee>();
            Tickets = new HashSet<Ticket>();
            EventAdmins = new HashSet<EventAdmin>();
            UserInterests = new HashSet<UserInterest>();
            EventApprovals = new HashSet<EventApproval>();
            Discussions = new HashSet<Discussion>();
            NotificationUsers = new HashSet<NotificationUser>();
        }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [DefaultValue(false)]
        public bool EmailConfirmed { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [DefaultValue(false)]
        public bool PhoneNumberConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<UserLogin> Logins { get; set; }
        public virtual ICollection<EventAttendee> EventAttendees { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<EventAdmin> EventAdmins { get; set; }
        public virtual ICollection<UserInterest> UserInterests { get; set; }
        public virtual ICollection<EventApproval> EventApprovals { get; set; }
        public virtual ICollection<Discussion> Discussions { get; set; }
        public virtual ICollection<NotificationUser> NotificationUsers { get; set; }

    }
}
