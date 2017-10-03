using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fogvent.Models.Entities
{
    public class Discussion : EntityBase
    {
        public Guid EventId { get; set; }
        public Guid UserId { get; set; }
        [Required]
        public string  Message { get; set; }

        [ForeignKey("EventId")]
        public virtual Event Event { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
