using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskRazorApp.Models;

namespace MegaDeskRazorApp.Pages.Quotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskRazorApp.Models.MegaDeskRazorAppContext _context;

        public IndexModel(MegaDeskRazorApp.Models.MegaDeskRazorAppContext context)
        {
            _context = context;
        }

        public IList<Quote> Quote { get;set; }

        public async Task OnGetAsync()
        {
            Quote = await _context.Quote.ToListAsync();
        }
    }
}
