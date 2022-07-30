using System;
using System.ComponentModel.DataAnnotations;

namespace Ticket.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public byte[] Image { get; set; }
        public int Views { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }
    }
}
