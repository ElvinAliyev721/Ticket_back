using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using Ticket.DAL;
using Ticket.Models;
using Ticket.ViewModels;

namespace Ticket.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public ContactController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index(ContactVM contact)
        {
            return View(contact);
        }

        [HttpPost]
        public IActionResult SendContact(ContactVM contact)
        {
            try
            {
                Contact _contact = new Contact
                {
                    Email = contact.Email,
                    Message = contact.Message,
                    Name = contact.Name,
                    SendedTime = DateTime.Now.ToString()
                };
                _context.Contacts.Add(_contact);
                _context.SaveChanges();
                return RedirectToAction("Index","Home");
            }
            catch (Exception)
            {
                TempData["Status"] = "Səhvlik baş verdi!";
                return RedirectToAction("Index",contact);
            }
        }
    }
}
