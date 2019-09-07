using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace flightApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FlightContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FlightContext>>()))
            {
                // Look for any flights.
                if (context.flight.Any())
                {
                    return;   // DB has been seeded
                }
                context.flight.AddRange(
                    new Flight
                    {
                        departure = "LAX",
                        destination = "SGN",
                        departureTime = new DateTime(2019, 8, 18, 16, 30, 0),
                        arrivalTime = new DateTime(2019, 8, 19, 17, 30, 0),
                        Class = "Economy",
                        Price = 120M
                    },
                    new Flight
                    {
                        departure = "SNA",
                        destination = "SGN",
                        departureTime = new DateTime(2019, 8, 19, 16, 30, 0),
                        arrivalTime = new DateTime(2019, 8, 20, 17, 30, 0),
                        Class = "Economy",
                        Price = 120M
                    },
                    new Flight
                    {
                        departure = "SFO",
                        destination = "SGN",
                        departureTime = new DateTime(2019, 8, 20, 16, 30, 0),
                        arrivalTime = new DateTime(2019, 8, 21, 17, 30, 0),
                        Class = "Economy",
                        Price = 120M
                    },
                    new Flight
                    {
                        departure = "SFO",
                        destination = "SGN",
                        departureTime = new DateTime(2019, 8, 21, 16, 30, 0),
                        arrivalTime = new DateTime(2019, 8, 22, 17, 30, 0),
                        Class = "Economy",
                        Price = 120M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}