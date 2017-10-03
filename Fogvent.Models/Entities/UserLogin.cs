using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fogvent.Models.Entities
{
    public class UserLogin : EntityBase
    {
        [Required]
        public string LoginProvider { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public DateTime LoginDateTime { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
