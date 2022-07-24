using Microsoft.AspNetCore.Http;

namespace Ticket.ViewModels
{
    public class FileUpload
    {
        public IFormFile File { get; set; }
        public string Obj { get; set; }
    }
}
