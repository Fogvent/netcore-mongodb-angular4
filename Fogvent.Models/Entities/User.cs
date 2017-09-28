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
            Roles = new List<IdentityUserRole>();
            Claims = new List<IdentityUserClaim>();
            Logins = new List<IdentityUserLogin>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override ICollection<IdentityUserRole> Roles { get; }
        public override ICollection<IdentityUserClaim> Claims { get; }
        public override ICollection<IdentityUserLogin> Logins { get; }
    }
}
