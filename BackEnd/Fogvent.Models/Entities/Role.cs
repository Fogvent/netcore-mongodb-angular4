using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Role : BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
