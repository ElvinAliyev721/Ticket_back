using System;

namespace Ticket.Areas.AdminPanel.ViewModels
{
    public class WarrantInfoVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Category { get; set; }
    }
}
