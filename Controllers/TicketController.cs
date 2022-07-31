using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ticket.DAL;
using Ticket.Models;
using Ticket.ViewModels;
using X.PagedList;

namespace Ticket.Controllers
{
    public class TicketController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public TicketController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Tickets(int page = 1)
        {
            List<WarrantsVM> warrants = new List<WarrantsVM>();
            try
            {
                foreach (Warrant item in await _context.Warrants.Where(x=>x.IsDeleted==false).Include(x=>x.Category).ToListAsync())
                {
                    WarrantsVM warrant = new WarrantsVM
                    {
                        Id = item.Id,
                        Name = item.Name,
                        CreateDate = item.CreateDate,
                        ExpireDate = item.ExpireDate,
                        Description = item.Description.Length > 100 ? item.Description.Substring(0, 99) : item.Description,
                        Price = item.Price,
                        Category = item.Category.Name
                    };
                    warrants.Add(warrant);
                };
                return View(warrants.ToPagedList(page, 6));
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> TicketDetails(int id)
        {
            try
            {
                Warrant warrant = await _context.Warrants.Include(x=>x.Category).FirstOrDefaultAsync(x=>x.Id==id);
                if(warrant!=null)
                return View(warrant);
                return RedirectToAction("Error404", "Error");

            }
            catch (Exception)
            {
                return RedirectToAction("Error404","Error");
            }
        }
    }
}
