using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Ticket.Areas.AdminPanel.ViewModels;
using Ticket.DAL;
using Ticket.Models;
using Ticket.Utils;
using Ticket.ViewModels;
using X.PagedList;

namespace Ticket.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles ="Admin")]
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
                    Views = blog.Views,
                    Image = Helper.GetImage(Convert.ToBase64String(blog.Image))
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
        public async Task<IActionResult> BlogEdit(FileUploadBlog fileObj)
        {
            BlogEditFileVM oBlog = JsonConvert.DeserializeObject<BlogEditFileVM>(fileObj.Blog);
            try
            {
                Blog blog = await _context.Blogs.FindAsync(oBlog.id);
                blog.Content = oBlog.content;
                blog.Title = oBlog.title;
                if (fileObj.File.Length > 0)
                {
                    using (var ms = new MemoryStream())
                    {
                        fileObj.File.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        blog.Image = fileBytes;
                    }
                }
                _context.Blogs.Update(blog);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("BlogEdit",oBlog.id);
            }
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BlogAdd(FileUploadBlog fileObj)
        {
            BlogFileVM oBlog = JsonConvert.DeserializeObject<BlogFileVM>(fileObj.Blog);
            try
            {
                if(fileObj.File.Length > 0)
                {
                    using(var ms = new  MemoryStream())
                    {
                        fileObj.File.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        Blog blog = new Blog
                        {
                            Title = oBlog.title,
                            Content = oBlog.content,
                            Image = fileBytes,
                            Status = true,
                            Views = 0,
                            Date = DateTime.Now
                        };
                        await _context.Blogs.AddAsync(blog);
                        await _context.SaveChangesAsync();

                        if(blog.Id > 0)
                        {
                            return RedirectToAction("Index");
                        }
                    }
                }
                TempData["ImageError"] = "Şəkil düzgün daxil edilməmişdir";
                return RedirectToAction("BlogAdd", oBlog);
            }
            catch (Exception)
            {
                return RedirectToAction("BlogAdd", oBlog);
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

        [HttpPost]
        public async Task<JsonResult> DeleteBlog(int id)
        {
            try
            {
                Blog blog = await _context.Blogs.FindAsync(id);
                blog.Status = false;
                _context.Blogs.Update(blog);
                _context.SaveChanges();
                return Json("Success");
            }
            catch (Exception)
            {
                return Json("Fail");
            }
        }

        [HttpPost]
        public async Task<JsonResult> ActivateBlog(int id)
        {
            try
            {
                Blog blog = await _context.Blogs.FindAsync(id);
                blog.Status = true;
                _context.Blogs.Update(blog);
                _context.SaveChanges();
                return Json("Success");
            }
            catch (Exception)
            {
                return Json("Fail");
            }
        }
    }
}
