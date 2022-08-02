using System;

namespace Ticket.Areas.AdminPanel.ViewModels
{
    public class WarrantVMA
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsDeleted { get; set; }
        public string Category { get; set; }
    }
}
