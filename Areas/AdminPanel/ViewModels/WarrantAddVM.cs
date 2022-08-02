using System;

namespace Ticket.Areas.AdminPanel.ViewModels
{
    public class WarrantAddVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public int CategoryId { get; set; }
    }
}
