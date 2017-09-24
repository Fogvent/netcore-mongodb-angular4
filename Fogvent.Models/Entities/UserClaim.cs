using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;
namespace Fogvent.Models.Entities
{
    public class UserClaim : IdentityUserClaim
    {
        [Key]
        public override int Id { get; set; }
    }
}
