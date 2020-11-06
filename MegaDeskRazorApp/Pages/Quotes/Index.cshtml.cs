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
        public string SortByName { get; set; }
        public string SortByDate { get; set; }

        [BindProperty (SupportsGet = true)]
        public string SearchByName { get; set; }

        public async Task OnGetAsync(string SortQuote)
        {
            SortByName = String.IsNullOrEmpty(SortQuote) ? "sort_quote_name_desc" : "";
            SortByDate = SortQuote == "QuoteDate" ? "sort_quote_date_desc" : "QuoteDate";

            var quotes = from m in _context.Quote select m;

            if(!string.IsNullOrEmpty(SearchByName))
            {
                quotes = quotes.Where(s => s.customerName.Contains(SearchByName));
            }

            switch(SortQuote)
            {
                case "sort_quote_name_desc":
                    quotes = quotes.OrderByDescending(s => s.customerName);
                    break;

                case "QuoteDate":
                    quotes = quotes.OrderBy(s => s.quoteDate);
                    break;
                case "sort_quote_date_desc":
                    quotes = quotes.OrderByDescending(s => s.quoteDate);
                    break;
                default:
                    quotes = quotes.OrderBy(s => s.customerName);
                    break;
            }

            Quote = await quotes.ToListAsync();
        }
    }
}
