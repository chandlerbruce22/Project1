
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            Console.WriteLine("Start EnsurePopulated.");

            TourDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<TourDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Tours.Any())
            {
                List<Tour> toursToAdd = new List<Tour>();

                for (int iOuter = 15; iOuter < 16; iOuter++)
                {
                    for (int iInner = 8; iInner < 21; iInner++)
                    {
                        toursToAdd.Add(
                            new Tour
                            {
                                TourTime = new DateTime(
                                    year: 2021,
                                    month: 3,
                                    day: iOuter,
                                    hour: iInner,
                                    minute: 00,
                                    second: 00
                                    )
                            }
                        )
                        ;
                    }
                }

                Console.WriteLine("Finished creating the tours.");

                context.Tours.AddRange(toursToAdd);

                Console.WriteLine("Finished adding the tour times to the DB.");

                context.SaveChanges();

                Console.WriteLine("Finished saving changes to the DB.");
            }
        }

    }
}
