using SpotParkApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotParkApi.Data
{
    public class DBInitializer
    {
        public static void Initialize(SpotParkApiContext context)
        {
            if (context.ParkingSpot.Any())
            {
                return;   // DB has been seeded
            }

            var spots = new ParkingSpot[]
            {
                new ParkingSpot
                {
                    Title = "Northgate",
                    Size = 4,
                    Location = "Northgate",
                    LocationIdentifier = "Thorton",
                    SpecialInstructions = "Creek",
                    Cost = 1,
                    AvailabilityStart = DateTime.Now,
                    AvailabilityEnd = DateTime.Now,
                    Email = "test@gmail.com"

                },
                new ParkingSpot
                {
                    Title = "Ballard",
                    Size = 3,
                    Location = "Ballard",
                    LocationIdentifier = "Near High School",
                    SpecialInstructions = "Shit Creek",
                    Cost = 2,
                    AvailabilityStart = DateTime.Now,
                    AvailabilityEnd = DateTime.Now,
                    Email = "test1@gmail.com"

                },
                new ParkingSpot
                {
                    Title = "Eastlake",
                    Size = 2,
                    Location = "Eastlake",
                    LocationIdentifier = "South Lake Union",
                    SpecialInstructions = "Margaritas",
                    Cost = 3,
                    AvailabilityStart = DateTime.Now,
                    AvailabilityEnd = DateTime.Now,
                    Email = "test2@gmail.com"

                },
                new ParkingSpot
                {
                    Title = "Capital Hill",
                    Size = 1,
                    Location = "Capital Hill",
                    LocationIdentifier = "Hippies",
                    SpecialInstructions = "First Come First Serve",
                    Cost = 5,
                    AvailabilityStart = DateTime.Now,
                    AvailabilityEnd = DateTime.Now,
                    Email = "test3@gmail.com"

                },
                new ParkingSpot
                {
                    Title = "Everette",
                    Size = 7,
                    Location = "Everette",
                    LocationIdentifier = "Comcast Arena",
                    SpecialInstructions = "YMCA",
                    Cost = 0,
                    AvailabilityStart = DateTime.Now,
                    AvailabilityEnd = DateTime.Now,
                    Email = "test4@gmail.com"

                }

            };
            foreach (ParkingSpot p in spots)
            {
                context.ParkingSpot.Add(p);
            }
            context.SaveChanges();
        }
    }
}
