using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fogvent.Models.Entities
{
    public class Category : EntityBase
    {
        public Category()
        {
            Topics = new HashSet<Topic>();
        }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Topic> Topics { get; set; }
    }
}
