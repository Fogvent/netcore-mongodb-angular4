using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Fogvent.Models.Entities
{
    [Table("AspNetUserRoles")]
    public class UserRole:IdentityUserRole
    {
        [Key]
        public string Id { get; set; }
    }
}
