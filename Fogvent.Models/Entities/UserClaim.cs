using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Fogvent.Models.Entities
{
    [Table("AspNetUserClaims")]
    public class UserClaim : IdentityUserClaim
    {
        [Key]
        public override int Id { get; set; }
    }
}
