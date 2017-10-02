using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Fogvent.Models.Entities
{
    public class Notification : EntityBase
    {
        public Notification()
        {
            NotificationUsers = new HashSet<NotificationUser>();
        }

        [Required]
        public string NotificationHeader { get; set; }
        [Required]
        public string NotificationBody { get; set; }
        [Required, DefaultValue(false)]
        public bool IsGlobale { get; set; }

        public virtual ICollection<NotificationUser> NotificationUsers { get; set; }
    }
}
