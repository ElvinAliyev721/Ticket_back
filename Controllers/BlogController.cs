using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Ticket.DAL;
using Ticket.Models;
using Ticket.ViewModels;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
using System;
using System.Collections.Generic;
using X.PagedList;

namespace Ticket.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public BlogController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Blogs(int page = 1)
        {
            List<BlogsVM> blogs = new List<BlogsVM>();
            try
            {
                foreach (Blog item in await _context.Blogs.ToListAsync())
                {
                    BlogsVM blog = new BlogsVM
                    {
                        Id = item.Id,
                        Title = item.Title,
                        Content = item.Content.Length > 100 ? item.Content.Substring(0, 99) : item.Content,
                        Date = item.Date,
                        //Image = 
                        Views = item.Views
                    };
                    blogs.Add(blog);
                };
                return View(blogs.ToPagedList(page,6));
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> BlogDetails(int id)
        {
            try
            {
                Blog blog = await _context.Blogs.FindAsync(id);
                return View(blog);
            }
            catch (Exception)
            {
                return RedirectToAction("BlogDetails",id++);
            }
        }

        //public void SaveFile(FileUpload fileObj)
        //{
        //    Blog blog = JsonConvert.DeserializeObject<Blog>(fileObj.Obj);
        //    if(fileObj.File.Length > 0)
        //    {
        //        using(var ms = new MemoryStream())
        //        {
        //            fileObj.File.CopyTo(ms);
        //            var fileBytes = ms.ToArray();
        //            blog.Image = fileBytes;
        //        }
        //    }
        //    _context.Blogs.Add(blog);
        //    _context.SaveChanges();
        //}

        //public JsonResult GetSavedBlog()
        //{
        //    var blog = _context.Blogs.FirstOrDefault();
        //    blog.Image = this.GetImage(Convert.ToBase64String(blog.Image));
        //    return Json(blog);
        //}

        //public byte[] GetImage(string sBase64String)
        //{
        //    byte[] bytes = null;
        //    if(!string.IsNullOrEmpty(sBase64String))
        //    {
        //        bytes = Convert.FromBase64String(sBase64String);
        //    }
        //    return bytes;
        //}
    }
}
