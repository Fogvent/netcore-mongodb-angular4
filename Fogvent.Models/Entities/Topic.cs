using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fogvent.Models.Entities
{
    public class Topic : EntityBase
    {
        public Topic()
        {
            UserInterests = new HashSet<UserInterest>();
            EventTopics = new HashSet<EventTopic>();
        }

        [Required]
        public string Name { get; set; }
        [Required, DefaultValue(true)]
        public bool IsActive { get; set; }
        public Guid CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public virtual ICollection<UserInterest> UserInterests { get; set; }
        public virtual ICollection<EventTopic> EventTopics { get; set; }
    }
}
