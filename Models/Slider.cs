using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ticket.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ImageText { get; set; }
        [NotMapped]
        [Required]
        public byte[] Photo { get; set; }
        [NotMapped]
        [Required]
        public List<byte[]> Photos { get; set; }
    }
}
