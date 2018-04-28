using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entities
{
    public class EventAdmin : BaseEntity
    {
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid EventId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        [ForeignKey("EventId")]
        public virtual Event Event { get; set; }
    }
}
