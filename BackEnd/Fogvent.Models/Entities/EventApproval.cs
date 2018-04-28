using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class EventApproval : BaseEntity
    {
        public Guid ApproverId { get; set; }
        public Guid EventId { get; set; }
        [Required, DefaultValue(false)]
        public bool IsApproved { get; set; }
        public string RejectionReason { get; set; }
        public DateTime DecisionDate { get; set; }

        [ForeignKey("ApproverId")]
        public virtual User Approver { get; set; }
        [ForeignKey("EventId")]
        public virtual Event Event { get; set; }
    }
}
