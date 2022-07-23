using System.Collections.Generic;
using Ticket.Models;

namespace Ticket.ViewModels
{
    public class HomeVM
    {
        public ICollection<Slider> Sliders { get; set; }
        public ICollection<Category> Categorys { get; set; }
        public ICollection<Warrant> Warrants { get; set; }
    }
}
