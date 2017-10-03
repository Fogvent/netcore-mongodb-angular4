using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fogvent.Models.Entities
{
    public class NotificationUser : EntityBase
    {
        public Guid NotificationId { get; set; }
        public Guid UserId { get; set; }
        [Required, DefaultValue(false)]
        public bool IsSeen { get; set; }

        [ForeignKey("NotificationId")]
        public virtual Notification Notification { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
