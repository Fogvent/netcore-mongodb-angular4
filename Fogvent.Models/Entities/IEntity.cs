using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fogvent.Models.Entities
{
    public abstract class IEntity
    {
        string CreatedUserId { get; set; }
        DateTime CreatedDate { get; set; }
        string LastUpdateUserId { get; set; }
        DateTime LastUpdateDate { get; set; }
    }
}
