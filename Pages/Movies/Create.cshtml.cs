using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DwayneRazorMovies.Data;
using DwayneRazorMovies.Modules;

namespace DwayneRazorMovies.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly DwayneRazorMovies.Data.ApplicationDbContext _context;

        public CreateModel(DwayneRazorMovies.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movies Movies { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movies.Add(Movies);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
