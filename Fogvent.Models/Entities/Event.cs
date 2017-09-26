using System.ComponentModel.DataAnnotations;

namespace Fogvent.Models.Entities
{
    public class Event : EntityBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public bool IsApproved { get; set; }
    }
}
