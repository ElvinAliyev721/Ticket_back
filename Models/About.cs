using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ticket.Models
{
    public class About {
        [Key]
        public int Id { get; set; }
        [Required,MinLength(25)]
        public string Title { get; set; }
        [Required,MinLength(120)]
        public string Description { get; set; }
        public string Image { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }
    }
}
