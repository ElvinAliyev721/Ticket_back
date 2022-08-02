using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ticket.Areas.AdminPanel.ViewModels;
using Ticket.DAL;
using Ticket.Models;
using X.PagedList;

namespace Ticket.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles = "Admin")]
    public class WarrantController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public WarrantController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            List<WarrantVMA> tickets = new List<WarrantVMA>();
            try
            {
                foreach (Warrant item in await _context.Warrants.Include(x => x.Category).ToListAsync())
                {
                    WarrantVMA warrant = new WarrantVMA
                    {
                        Id = item.Id,
                        Name = item.Name,
                        IsDeleted = item.IsDeleted,
                        Price = item.Price,
                        Category = item.Category.Name
                    };
                    tickets.Add(warrant);
                };
                return View(tickets.ToPagedList(page, 8));
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> WarrantAdd()
        {
            try
            {
                List<CategoryComboBoxVM> list = new List<CategoryComboBoxVM>();
                foreach (Category item in await _context.Categories.Where(x=>x.IsDeleted==false).ToListAsync())
                {
                    CategoryComboBoxVM data = new CategoryComboBoxVM
                    {
                        CategoryId = item.Id,
                        CategoryName = item.Name
                    };
                    list.Add(data);
                }
                ViewBag.CategoryList = list;
                return View();
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public async Task<IActionResult> WarrantAdd(WarrantAddVM warrantVM)
        {
            try
            {
                if (warrantVM != null)
                {
                    Warrant warrant = new Warrant
                    {
                        Name = warrantVM.Name,
                        CategoryId = warrantVM.CategoryId,
                        Price = warrantVM.Price,
                        CreateDate = warrantVM.CreateDate,
                        ExpireDate = warrantVM.ExpireDate,
                        Description = warrantVM.Description,
                        IsDeleted = false
                    };
                    await _context.Warrants.AddAsync(warrant);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("WarrantAdd", warrantVM);
            }
        }

        [HttpGet]
        public async Task<IActionResult> WarrantEdit(int id)
        {
            try
            {
                Warrant warrant = await _context.Warrants.FindAsync(id);
                if (warrant != null)
                {
                    WarrantAddVM warrantVM = new WarrantAddVM
                    {
                        CategoryId = warrant.CategoryId,
                        Description = warrant.Description,
                        CreateDate = warrant.CreateDate,
                        ExpireDate = warrant.ExpireDate,
                        Name = warrant.Name,
                        Price = warrant.Price,
                        Id = warrant.Id
                    };
                    List<CategoryComboBoxVM> list = new List<CategoryComboBoxVM>();
                    foreach (Category item in await _context.Categories.Where(x => x.IsDeleted == false).ToListAsync())
                    {
                        CategoryComboBoxVM data = new CategoryComboBoxVM
                        {
                            CategoryId = item.Id,
                            CategoryName = item.Name
                        };
                        list.Add(data);
                    }
                    ViewBag.CategoryList = list;
                    return View(warrantVM);
                }
                else
                    return View(new WarrantAddVM());
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> WarrantEdit(WarrantAddVM editedWarrant)
        {
            try
            {
                if (editedWarrant != null)
                {
                    Warrant warrant = await _context.Warrants.FindAsync(editedWarrant.Id);
                    warrant.Price = editedWarrant.Price;
                    warrant.Name = editedWarrant.Name;
                    warrant.Description = editedWarrant.Description;
                    warrant.CategoryId = editedWarrant.CategoryId;
                    warrant.CreateDate = editedWarrant.CreateDate;
                    warrant.ExpireDate = editedWarrant.ExpireDate;
                    _context.Warrants.Update(warrant);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("WarrantEdit", editedWarrant);
            }
        }

        public async Task<JsonResult> WarrantDetails(int id)
        {
            try
            {
                Warrant warrant = await _context.Warrants.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id);
                WarrantInfoVM warrantInfo = new WarrantInfoVM()
                {
                    Id = warrant.Id,
                    Price = warrant.Price,
                    Name = warrant.Name,
                    Description = warrant.Description.Length > 150 ? warrant.Description.Substring(0, 150) : warrant.Description,
                    Category = warrant.Category.Name,
                    CreateDate = warrant.CreateDate,
                    ExpireDate = warrant.ExpireDate,
                    IsDeleted = warrant.IsDeleted
                };
                string data = JsonConvert.SerializeObject(warrantInfo);
                return Json(data);
            }
            catch (Exception)
            {
                WarrantInfoVM warrant = new WarrantInfoVM()
                {
                    Id = 1,
                    CreateDate = DateTime.Now,
                    ExpireDate = DateTime.Now,
                    Category = "Xeta",
                    Description = "Xeta",
                    IsDeleted = true,
                    Name = "Xeta",
                    Price = 0
                };
                string data = JsonConvert.SerializeObject(warrant);
                return Json(data);
            }
        }
    }
}
