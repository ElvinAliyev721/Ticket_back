using System.ComponentModel.DataAnnotations;

namespace Ticket.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required, EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        [Required, MinLength(100)]
        public string Message { get; set; }
        public string SendedTime { get; set; }
    }
}
