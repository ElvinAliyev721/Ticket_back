using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Ticket.DAL;
using Ticket.Models;
using X.PagedList;

namespace Ticket.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles ="Admin")]
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult>  Index(int page = 1)
        {
            var data = await _context.Contacts.ToListAsync();
            return View(data.ToPagedList(page, 6));
        }

        public async Task<IActionResult> ContactDetails(int? id)
        {
            if (id == null)
            {
                Contact contact1 = new Contact
                {
                    Id = 1,
                    Email = "Xeta",
                    Message = "Xeta",
                    Name = "Xeta",
                    SendedTime = "Xeta"
                };
                string data = JsonConvert.SerializeObject(contact1);
                return Json(data);
            }
            Contact contact = await _context.Contacts.FindAsync(id);
            if (contact == null)
            {
                Contact contact1 = new Contact
                {
                    Id = 1,
                    Email = "Xeta",
                    Message = "Xeta",
                    Name = "Xeta",
                    SendedTime = "Xeta"
                };
                string data = JsonConvert.SerializeObject(contact1);
                return Json(data);
            }
            string _data = JsonConvert.SerializeObject(contact);
            return Json(_data);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Contact contact = await _context.Contacts.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteContact(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Contact contact = await _context.Contacts.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            _context.Contacts.Remove(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
