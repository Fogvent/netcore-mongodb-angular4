using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fogvent.Models.Entities
{
    public class Event : EntityBase
    {
        public Event()
        {
            Tickets = new HashSet<Ticket>();
            EventAttendees = new HashSet<EventAttendee>();
            EventAdmins = new HashSet<EventAdmin>();
            EventTopics = new HashSet<EventTopic>();
            Discussions = new HashSet<Discussion>();
        }

        [Required]
        public string Name { get; set; }
        [Required]
        public bool IsApproved { get; set; }
        [Required, DefaultValue(0)]
        public int TicketAvailableCount { get; set; }
        public Guid AgendaId { get; set; }

        [ForeignKey("AgendaId")]
        public virtual Agenda Agenda { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<EventAttendee> EventAttendees { get; set; }
        public virtual ICollection<EventAdmin> EventAdmins { get; set; }
        public virtual ICollection<EventTopic> EventTopics { get; set; }
        public virtual ICollection<Discussion> Discussions { get; set; }

    }
}
