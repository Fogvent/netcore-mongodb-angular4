using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Fogvent.Models.Entities
{
    [Table("AspNetUserLogins")]
    public class UserLogin:IdentityUserLogin
    {
        [Key]
        public string Id { get; set; }
    }
}
