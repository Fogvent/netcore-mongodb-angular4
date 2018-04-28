using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class EventTopic : BaseEntity
    {
        public Guid EventId { get; set; }
        public Guid TopicId { get; set; }

        [ForeignKey("EventId")]
        public virtual Event Event { get; set; }
        [ForeignKey("TopicId")]
        public virtual Topic Topic { get; set; }
    }
}
