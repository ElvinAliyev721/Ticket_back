using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ticket.Models
{
    public class About
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Description { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }
    }
}
