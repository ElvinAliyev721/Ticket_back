using System.IO;

namespace Ticket.DeleteHelper
{
    public static class ImageDeleter
    {
        public static void DeleteFile(string fileName, string root, string folder)
        {
            string resultPath = Path.Combine(root, folder, fileName);

            bool isExist = File.Exists(resultPath);
            if (isExist)
            {
                File.Delete(resultPath);
            }
        }
    }
}
