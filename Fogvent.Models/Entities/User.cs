using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Fogvent.Models.Entities
{
    [Table("AspNetUsers")]
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
