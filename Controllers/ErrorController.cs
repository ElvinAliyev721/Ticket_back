using Microsoft.AspNetCore.Mvc;

namespace Ticket.Controllers
{
    public class ErrorController : Controller
    {
        [Route("/Error/{statusCode}")]
        public IActionResult Index(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Narahatçılığa görə çox üzr istəyirik. Deyəsən, silinmiş və ya heç vaxt mövcud olmayan səhifəyə daxil olmağa çalışırsınız.";
                    break;
                default:
                    ViewBag.ErrorMessage = "Bilinməyən xəta :(";
                    break;
            }
            return View();
        }

        public IActionResult Error404()
        {
            return View();
        }
    }
}
