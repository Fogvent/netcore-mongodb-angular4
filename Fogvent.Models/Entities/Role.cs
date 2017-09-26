using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Fogvent.Models.Entities
{
    [Table("AspNetRoles")]
    public class Role:IdentityRole
    {
    }
}
