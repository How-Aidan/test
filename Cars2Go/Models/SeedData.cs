using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Cars2Go.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Cars2GoContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Cars2GoContext>>()))
            {
                // Look for any movies.
                if (context.Rental.Any())
                {
                    return;   // DB has been seeded
                }

                context.Rental.AddRange(
                    new Rental
                    {
                        RegNumID = "56 YY UH GP",
                        StartDate = DateTime.Parse("12-2-2019"),
                        EndDate = DateTime.Parse("19-2-2019"),
                        RentalID = 1,
                        IDNum = "9702225154083",
                        Price = 2000
                   
                    },

                    new Rental
                    {
                        RegNumID = "57 GG UT GP",
                        StartDate = DateTime.Parse("2-3-2019"),
                        EndDate = DateTime.Parse("6-3-2019"),
                        RentalID = 2,
                        IDNum = "8902225154082",
                        Price = 2500

                    },

                    new Rental
                    {
                        RegNumID = "14 TE GE GP",
                        StartDate = DateTime.Parse("24-2-2019"),
                        EndDate = DateTime.Parse("5-3-2019"),
                        RentalID = 3,
                        IDNum = "9705226154083",
                        Price = 3000

                    },

                    new Rental
                    {
                        RegNumID = "67 TY ZQ GP",
                        StartDate = DateTime.Parse("5-5-2019"),
                        EndDate = DateTime.Parse("20-5-2019"),
                        RentalID = 4,
                        IDNum = "9925075178082",
                        Price = 1750

                    }
                );
                context.SaveChanges();
            }
        }
    }
}