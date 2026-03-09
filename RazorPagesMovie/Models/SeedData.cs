using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesMovieContext>>()))
        {
            if (context == null || context.Concert == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            // Look for any movies.
            if (context.Concert.Any())
            {
                return;   // DB has been seeded
            }

            context.Concert.AddRange(
                new Concert
                {
                    Artist = "The Offspring",
                    Date = DateTime.Parse("2023-8-12"),
                    Venue = "Simmons Bank Arena",
                    City = "Little Rock, AR",
                    Price = 150M
                },
                
                new Concert
                {
                    Artist = "Dashboard Confessional",
                    Date = DateTime.Parse("2025-7-19"),
                    Venue = "Walmart AMP",
                    City = "Rogers, AR",
                    Price = 0M
                },

                new Concert
                {
                    Artist = "New Found Glory",
                    Date = DateTime.Parse("2025-8-18"),
                    Venue = "Ozark Music Hall",
                    City = "Fayetteville, AR",
                    Price = 20M
                }

         
            );
            context.SaveChanges();
        }
    }
}