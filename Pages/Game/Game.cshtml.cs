using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Exam.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Exam.Pages.Game
{
    public class GameModel : PageModel
    {
        private readonly Exam.Data.ApplicationDbContext _context;
        private readonly SignInManager<Exam.Data.User> _signInManager;
        private readonly UserManager<Exam.Data.User> __userManager;
        [BindProperty]
        public Exam.Data.Game Game {get; set;}

        public GameModel(ApplicationDbContext context, SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _context = context;
            _signInManager = signInManager;
            __userManager = userManager;
        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            var p =  _context.Games.Include(i => i.Users).Where(i => i.Id == 2);
            Game = await p.FirstOrDefaultAsync();
            return Page();
        }

    }
}
