using Microsoft.AspNetCore.Mvc;

namespace Ticket.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error404()
        {
            return View();
        }
    }
}
