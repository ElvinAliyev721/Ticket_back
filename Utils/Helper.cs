using System;

namespace Ticket.Utils
{
    public class Helper
    {
        public static byte[] GetImage(string sBase64)
        {
            byte[] bytes = null;
            if (!string.IsNullOrEmpty(sBase64))
            {
                bytes = Convert.FromBase64String(sBase64);
            }
            return bytes;
        }
    }
}
