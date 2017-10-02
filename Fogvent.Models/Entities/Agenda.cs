using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fogvent.Models.Entities
{
    public class Agenda : EntityBase
    {
        public Agenda()
        {
            AgendaSpeakers = new HashSet<AgendaSpeaker>();
        }

        public string Name { get; set; }
        public Guid EventId { get; set; }

        [ForeignKey("EventId")]
        public virtual Event Event { get; set; }

        public virtual ICollection<AgendaSpeaker> AgendaSpeakers { get; set; }
    }
}
