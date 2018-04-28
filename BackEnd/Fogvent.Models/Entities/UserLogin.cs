using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class UserLogin : BaseEntity
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
