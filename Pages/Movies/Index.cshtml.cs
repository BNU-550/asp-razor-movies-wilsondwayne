﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DwayneRazorMovies.Data;
using DwayneRazorMovies.Modules;

namespace DwayneRazorMovies.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly DwayneRazorMovies.Data.ApplicationDbContext _context;

        public IndexModel(DwayneRazorMovies.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Movies> Movies { get;set; }

        public async Task OnGetAsync()
        {
            Movies = await _context.Movies.ToListAsync();
        }
    }
}
