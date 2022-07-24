using System;
using System.Collections.Generic;
using Ticket.Models;

namespace Ticket.ViewModels
{
    public class BlogsVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public byte[] Image { get; set; }
        public int Views { get; set; }
        public DateTime Date { get; set; }
    }
}
