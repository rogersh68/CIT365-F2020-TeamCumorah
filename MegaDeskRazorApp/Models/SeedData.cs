using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskRazorApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDeskRazorAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<MegaDeskRazorAppContext>>()))
            {
                if (context.Quote.Any())
                {
                    return;
                }

                context.Quote.AddRange(
                    new Quote
                    {
                        customerName = "John Doe",
                        quoteDate = new DateTime(2020, 10, 31),
                        rushDays = 0,
                        deskWidth = 50,
                        deskDepth = 30,
                        deskDrawer = 2,
                        desktopMaterial = Quote.DesktopMaterial.Rosewood,
                        totalQuote = 200
                    },

                    new Quote
                    {
                        customerName = "Jane Doe",
                        quoteDate = new DateTime(2020, 11, 3),
                        rushDays = 5,
                        deskWidth = 40,
                        deskDepth = 20,
                        deskDrawer = 1,
                        desktopMaterial = Quote.DesktopMaterial.Oak,
                        totalQuote = 200
                    },

                    new Quote
                    {
                        customerName = "Hannah Rogers",
                        quoteDate = new DateTime(2020, 11, 6),
                        rushDays = 7,
                        deskWidth = 90,
                        deskDepth = 30,
                        deskDrawer = 3,
                        desktopMaterial = Quote.DesktopMaterial.Pine,
                        totalQuote = 200
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
