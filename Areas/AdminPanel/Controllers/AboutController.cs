using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Ticket.DAL;
using Ticket.ImageHelper;
using Ticket.Models;

namespace Ticket.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles = "Admin")]
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public AboutController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Abouts.ToListAsync());
        }
        public IActionResult Create()
        {
            if (_context.Abouts.Count()>0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(About about)
        {
            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {
                return View(about);
            }
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "dogru daxil edin");
                return View(about);
            }
            if (!about.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Fayl tipi dogru deyil");
                return View();
            }


            string filePath = _env.WebRootPath;
            string fileName = DateTime.Now.ToString("yyyyMMddHHmmss")+"_"+ 
                Guid.NewGuid().ToString()+"_" + 
                about.Photo.FileName;
            string resultPath = Path.Combine(filePath ,"img", fileName);

            using (FileStream fileStream = new FileStream(resultPath, FileMode.Create))
            {
                await about.Photo.CopyToAsync(fileStream);
            }
            about.Image = fileName;
            await _context.Abouts.AddAsync(about);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            About about = await _context.Abouts.FindAsync(id);
            if (about == null) return NotFound();
            return View(about);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteAbout(int? id)
        {
            if (id == null) return NotFound();
            About about = await _context.Abouts.FindAsync(id);
            if (about == null) return NotFound();

            string FilePath = _env.WebRootPath;
            string resultPath = Path.Combine(FilePath, "img", about.Image);

            bool isExist = System.IO.File.Exists(resultPath);
            if (isExist)
            {
                System.IO.File.Delete(resultPath);
            }
            //DeleteHelper.ImageDeleter.DeleteFile(about.Image, "img", FilePath);

            _context.Abouts.Remove(about);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            About about = await _context.Abouts.FindAsync(id);
            if (about == null) return NotFound();
            return View(about);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, About about)
        {
            if (id == null) return NotFound();
            About dbabout = await _context.Abouts.FindAsync(id);
            if (dbabout == null) return NotFound();

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {
                return View(about);
            }
            
                string filePath = _env.WebRootPath;
                string resultPath = Path.Combine(filePath, "img", dbabout.Image);

                bool isExist = System.IO.File.Exists(resultPath);
                if (isExist)
                {
                    System.IO.File.Delete(resultPath);
                }

                //Helper.Helper.DeleteFile(dbslider.Image, "img", _env.WebRootPath);

                string fileName = await about.Photo.SaveFileAsync(_env.WebRootPath, "img");

                dbabout.Image = fileName;
            
            dbabout.Title = about.Title;
            dbabout.Description = about.Description;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            About about = await _context.Abouts.FindAsync(id);
            if (about == null) return NotFound();
            return View(about);
        }
    }
}
