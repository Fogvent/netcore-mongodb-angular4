using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
