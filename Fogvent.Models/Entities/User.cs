using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Fogvent.Models.Entities
{
    [Table("AspNetUsers")]
    public class User : IdentityUser
    {
        public User()
        {
            Roles = new HashSet<IdentityUserRole>();
            Claims = new HashSet<IdentityUserClaim>();
            Logins = new HashSet<IdentityUserLogin>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override ICollection<IdentityUserRole> Roles { get; }
        public override ICollection<IdentityUserClaim> Claims { get; }
        public override ICollection<IdentityUserLogin> Logins { get; }
    }
}
