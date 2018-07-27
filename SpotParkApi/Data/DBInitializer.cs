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
                    Email = "test@gmail.com",
                    ReportCount = 1

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
                    Email = "test1@gmail.com",
                    ReportCount = 1

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
                    Email = "test2@gmail.com",
                    ReportCount = 1

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
                    Email = "test3@gmail.com",
                    ReportCount = 1

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
                    Email = "test4@gmail.com",
                    ReportCount = 1

                }

            };
            foreach (ParkingSpot p in spots)
            {
                context.ParkingSpot.Add(p);
            }
            context.SaveChanges();

            var reports = new Report[]
            {
                new Report {Message = "Scam",Email = "testR@gmail.com",ParkingSpotID = 1},
                new Report {Message = "Real Deal",Email = "testR1@gmail.com",ParkingSpotID = 2},
                new Report {Message = "Fake",Email = "testR2@gmail.com",ParkingSpotID = 3},
                new Report {Message = "Cool",Email = "testR3@gmail.com",ParkingSpotID = 4},
                new Report {Message = "Roomy",Email = "testR4@gmail.com",ParkingSpotID = 5},
            };

            foreach (Report r in reports)
            {
                context.Report.Add(r);
            }
            context.SaveChanges();
        }
    }
}
