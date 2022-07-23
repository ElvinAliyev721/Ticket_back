using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Ticket.Models
{
    public class AppUser:IdentityUser
    {
        [Required,MaxLength(200)]
        public string FullName { get; set; }
    }
}
