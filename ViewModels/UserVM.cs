using System.Collections.Generic;

namespace Ticket.ViewModels
{
    public class UserVM
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public bool IsDeleted { get; set; }
        public string Role { get; set; }
        public List<string> Roles { get; set; }
    }
}
