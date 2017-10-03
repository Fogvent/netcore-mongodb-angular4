using System.ComponentModel.DataAnnotations;

namespace Fogvent.Models.Entities
{
    public class Role : EntityBase
    {
        [Required]
        public string Name { get; set; }
    }
}
