using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Ticket.DAL;
using Ticket.Models;
using Ticket.ViewModels;

namespace Ticket.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            About db_about = await _context.Abouts.FirstOrDefaultAsync();
            AboutVM aboutvm = new AboutVM();
            int checkLength; ;
            if (db_about == null)
            {
                aboutvm.Title = "Test";
                aboutvm.Description_1 = "Desc_1";
                aboutvm.Description_2 = "Desc_2";
                aboutvm.Description_3 = "Desc_3";
                aboutvm.Image = "assets/img/about/1.png";
            }
            else
            {
                checkLength = db_about.Description.Length;
                int qaliq = 0;
                if (checkLength % 3 != 0)
                {
                    qaliq += checkLength % 3;
                }
                checkLength += qaliq;



                aboutvm.Title = db_about.Title;
                aboutvm.Image = db_about.Image;
                aboutvm.Description_1 = db_about.Description.Substring(0, checkLength / 3);
                aboutvm.Description_2 = db_about.Description.Substring(checkLength / 3, checkLength * 2 / 3);
                aboutvm.Description_3 = db_about.Description.Substring(checkLength * 2 / 3, checkLength - qaliq);
                
            }
            
            
            return View(aboutvm);
        }
    }
}
