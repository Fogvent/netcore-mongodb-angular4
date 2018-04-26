using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Speaker : BaseEntity
    {
        public Speaker()
        {
            AgendaSpeakers = new HashSet<AgendaSpeaker>();
        }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Introduction { get; set; }
        [Required]
        public string Title { get; set; }
        public string PhoneNumber { get; set; }

        //Comma Seprated
        public string SocialLinks { get; set; }

        public virtual ICollection<AgendaSpeaker> AgendaSpeakers { get; set; }
    }
}
