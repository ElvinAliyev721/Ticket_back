using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ticket.Areas.AdminPanel.ViewModels;
using Ticket.DAL;
using Ticket.Models;
using X.PagedList;

namespace Ticket.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public CategoryController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            try
            {
                List<Category> categories = await _context.Categories.ToListAsync();
                List<CategoryVM> categoryVMs = new List<CategoryVM>();
                foreach (var item in categories)
                {
                    CategoryVM category = new CategoryVM
                    {
                        Id = item.Id,
                        Name = item.Name,
                        IsDeleted = item.IsDeleted
                    };
                    categoryVMs.Add(category);
                }
                return View(categoryVMs.ToPagedList(page, 8));
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CategoryAdd(CategoryAddVM categoryVM)
        {
            try
            {
                if (categoryVM != null)
                {
                    Category category = new Category
                    {
                        Name = categoryVM.Name,
                        Description = categoryVM.Description,
                        IsDeleted = false
                    };
                    await _context.Categories.AddAsync(category);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("CategoryAdd", categoryVM);
            }
        }

        [HttpGet]
        public async Task<IActionResult> CategoryEdit(int id)
        {
            try
            {
                Category category = await _context.Categories.FindAsync(id);
                CategoryAddVM addVM = new CategoryAddVM
                {
                    Id = category.Id,
                    Description = category.Description,
                    Name = category.Name
                };
                return View(addVM);
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CategoryEdit(CategoryAddVM categoryVM)
        {
            try
            {
                if (categoryVM != null)
                {
                    Category category = await _context.Categories.FindAsync(categoryVM.Id);
                    category.Description = categoryVM.Description;
                    category.Name = categoryVM.Name;
                    _context.Categories.Update(category);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("CategoryEdit", categoryVM);
            }
        }

        public async Task<JsonResult> CategoryDetails(int id)
        {
            try
            {
                Category category = await _context.Categories.FindAsync(id);
                CategoryInfoVM categoryInfo = new CategoryInfoVM
                {
                    Id = category.Id,
                    Name = category.Name,
                    Description = category.Description.Length > 150 ? category.Description.Substring(0, 150) : category.Description,
                    IsDeleted = category.IsDeleted
                };
                string data = JsonConvert.SerializeObject(categoryInfo);
                return Json(data);
            }
            catch (Exception)
            {
                CategoryInfoVM category = new CategoryInfoVM
                {
                    Id = 1,
                    Name = "Xeta",
                    Description = "Xeta",
                    IsDeleted = true
                };
                string data = JsonConvert.SerializeObject(category);
                return Json(data);
            }
        }

        [HttpPost]
        public async Task<JsonResult> DeleteCategory(int id)
        {
            try
            {
                Category category = await _context.Categories.FindAsync(id);
                category.IsDeleted = true;
                _context.Categories.Update(category);
                await _context.SaveChangesAsync();
                return Json("Success");
            }
            catch (Exception)
            {
                return Json("Fail");
            }
        }

        [HttpPost]
        public async Task<JsonResult> ActivateCategory(int id)
        {
            try
            {
                Category category = await _context.Categories.FindAsync(id);
                category.IsDeleted = false;
                _context.Categories.Update(category);
                await _context.SaveChangesAsync();
                return Json("Success");
            }
            catch (Exception)
            {
                return Json("Fail");
            }
        }
    }
}
