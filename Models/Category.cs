using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ticket.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }


        [Required,MaxLength(200)]
        public string Name { get; set; }


        [Required,MaxLength(250)]
        public string Description { get; set; }


        [Required]
        public bool IsDeleted { get; set; }

        public virtual ICollection<Warrant> Warrants { get; set; }
    }
}
