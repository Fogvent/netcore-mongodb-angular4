using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            Id = new Guid();
            CreatedOn = DateTime.Now;
            ModifiedOn = DateTime.Now;
        }

        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public DateTime ModifiedOn { get; set; }
    }
}
