using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fogvent.Models.Entities
{
    public class UserInterest:EntityBase
    {
        public Guid UserId { get; set; }
        public Guid TopicId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        [ForeignKey("TopicId")]
        public virtual Topic Topic { get; set; }
    }
}
