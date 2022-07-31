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
using Ticket.Utils;

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
                foreach (Blog item in await _context.Blogs.Where(x=>x.Status==true).ToListAsync())
                {
                    BlogsVM blog = new BlogsVM
                    {
                        Id = item.Id,
                        Title = item.Title,
                        Content = item.Content.Length > 100 ? item.Content.Substring(0, 99) : item.Content,
                        Date = item.Date,
                        Image = Helper.GetImage(Convert.ToBase64String(item.Image)),
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
                blog.Image = Helper.GetImage(Convert.ToBase64String(blog.Image));
                return View(blog);
            }
            catch (Exception)
            {
                return RedirectToAction("BlogDetails",id++);
            }
        }

    }
}
