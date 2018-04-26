using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class AgendaSpeaker: BaseEntity
    {
        [Required]
        public Guid AgendaId { get; set; }
        [Required]
        public Guid SpeakerId { get; set; }
        [Required]
        public string TopicHeader { get; set; }
        [Required]
        public string TopicDetails { get; set; }
        [Required]
        public TimeSpan TimeFrom { get; set; }
        [Required]
        public TimeSpan TimeTo { get; set; }
        [Required]
        public DateTime SpeakingDate { get; set; }
        public int? Order { get; set; }

        [ForeignKey("AgendaId")]
        public virtual Agenda Agenda { get; set; }
        [ForeignKey("SpeakerId")]
        public virtual Speaker Speaker { get; set; }
    }
}
