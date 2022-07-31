using Microsoft.AspNetCore.Http;

namespace Ticket.ViewModels
{
    public class FileUploadBlog
    {
        public IFormFile File { get; set; }
        public string Blog { get; set; }
    }
}
