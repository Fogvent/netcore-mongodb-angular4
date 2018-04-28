using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Category : BaseEntity
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
