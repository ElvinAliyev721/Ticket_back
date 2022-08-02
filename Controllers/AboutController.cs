using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Ticket.DAL;
using Ticket.Models;
using Ticket.ViewModels;

namespace Ticket.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            About db_about = await _context.Abouts.FirstOrDefaultAsync();
            AboutVM aboutvm = new AboutVM();
            List<string> aboutSentences;
            if (db_about.Description != null)
            {
                string[] sentences = Regex.Split(db_about.Description, @"(?<=[\.!\?])");
                aboutSentences = sentences.ToList();
                for (int i = 0; i < aboutSentences.Count; i++)
                {
                    if (i < 5)
                        aboutvm.Description_1 += aboutSentences[i];
                    else if (i > 5 && i < 10)
                        aboutvm.Description_2 += aboutSentences[i];
                    else if (i > 10 && i < 15)
                        aboutvm.Description_3 += aboutSentences[i];
                    else
                        aboutvm.Description_4 += aboutSentences[i];
                }
            }
            return View(aboutvm);
        }
    }
}
