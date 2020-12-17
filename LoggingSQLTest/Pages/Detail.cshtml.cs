using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoggingSQLTest.Data;
using LoggingSQLTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace LoggingSQLTest.Pages
{
    public class DetailModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _context;

        public Game Game { get; set; }
        public DetailModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public void OnGet(int id)
        {
            Game = _context.Games.Where(g => g.Id == id).SingleOrDefault();
        }
    }
}
