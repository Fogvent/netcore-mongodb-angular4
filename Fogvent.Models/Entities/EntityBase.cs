using System;
using System.ComponentModel.DataAnnotations;

namespace Fogvent.Models.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase()
        {
            CreatedOn = DateTime.Now;
            ModifiedOn = DateTime.Now;
        }

        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        //[Required]
        //public User CreatedBy { get; set; }
        [Required]
        public DateTime ModifiedOn { get; set; }
        //[Required]
        //public User ModifiedBy { get; set; }
    }
}
