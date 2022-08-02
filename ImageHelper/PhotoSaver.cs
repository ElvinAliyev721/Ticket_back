using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Ticket.ImageHelper
{
    public static class PhotoSaver
    {
        public static async Task<string> SaveFileAsync(this IFormFile file, string fileroot, string folder)
        {
            string fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + Guid.NewGuid().ToString() + "_" + file.FileName;

            string resultPath = Path.Combine(fileroot, folder, fileName);

            using (FileStream fileStream = new FileStream(resultPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return fileName;
        }
    }
}
