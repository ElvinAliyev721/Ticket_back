using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ticket.Areas.AdminPanel.ViewModels;
using Ticket.DAL;
using Ticket.Models;
using Ticket.ViewModels;
using X.PagedList;

namespace Ticket.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public BlogController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            List<BlogsVMA> blogs = new List<BlogsVMA>();
            try
            {
                foreach (Blog item in await _context.Blogs.ToListAsync())
                {
                    BlogsVMA blog = new BlogsVMA
                    {
                        Id = item.Id,
                        Title = item.Title,
                        Content = item.Content.Length > 100 ? item.Content.Substring(0, 99) : item.Content,
                        Date = item.Date,
                        Status = item.Status,
                        //Image = 
                        Views = item.Views
                    };
                    blogs.Add(blog);
                };
                return View(blogs.ToPagedList(page, 8));
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> BlogEdit(int id)
        {
            try
            {
                Blog blog = await _context.Blogs.FindAsync(id);
                BlogsVMA blogInfo = new BlogsVMA()
                {
                    Id = blog.Id,
                    Content = blog.Content,
                    Status = blog.Status,
                    Date = blog.Date,
                    Title = blog.Title,
                    Views = blog.Views
                };
                return View(blogInfo);
            }
            catch (Exception)
            {
                BlogsVMA blogInfo = new BlogsVMA()
                {
                    Id = 1,
                    Content = "Xeta",
                    Status = false,
                    Date = DateTime.Now,
                    Title = "Xeta",
                    Views = 0
                };
                return View(blogInfo);
            }
        }

        [HttpPost]
        public async Task<IActionResult> BlogEdit(BlogsVMA blogNew)
        {
            try
            {
                Blog blog = await _context.Blogs.FindAsync(blogNew.Id);
                blog.Content = blogNew.Content;
                blog.Status = blogNew.Status;
                blog.Date = blogNew.Date;
                blog.Title = blogNew.Title;
                blog.Views = blogNew.Views;
                _context.Blogs.Update(blog);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("BlogEdit",blogNew.Id);
            }
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BlogAdd(BlogsVMA blogNew)
        {
            try
            {
                Blog blog = new Blog
                {
                    Content = blogNew.Content,
                    Status = true,
                    Date = DateTime.Now,
                    Title = blogNew.Title,
                    Views = 0,
                    //Image = 
                };
                await _context.Blogs.AddAsync(blog);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("BlogAdd", blogNew);
            }
        }

        public async Task<JsonResult> BlogDetails(int id)
        {
            try
            {
                Blog blog = await _context.Blogs.FindAsync(id);
                BlogsVMA blogInfo = new BlogsVMA()
                {
                    Id = blog.Id,
                    Content = blog.Content,
                    Status = blog.Status,
                    Date = blog.Date,
                    Title = blog.Title,
                    Views = blog.Views
                };
                string data = JsonConvert.SerializeObject(blogInfo);
                return Json(data);
            }
            catch (Exception)
            {
                BlogsVMA blogInfo = new BlogsVMA()
                {
                    Id = 1,
                    Content = "Xeta",
                    Status = false,
                    Date = DateTime.Now,
                    Title = "Xeta",
                    Views = 0
                };
                string data = JsonConvert.SerializeObject(blogInfo);
                return Json(data);
            }
        }

    }
}
