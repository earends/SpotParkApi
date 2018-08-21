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
                    Size = "small",
                    Location = "Northgate",
                    SpecialInstructions = "Creek",
                    Cost = 1,
                   
                    Email = "test@gmail.com",
                   
                },
                new ParkingSpot
                {
                    Title = "Ballard",
                    Size = "small",
                    Location = "Ballard",
                    
                    SpecialInstructions = "Creek",
                    Cost = 2,
                    
                    Email = "test1@gmail.com",
                    

                },
                new ParkingSpot
                {
                    Title = "Eastlake",
                    Size = "small",
                    Location = "Eastlake",
                    
                    SpecialInstructions = "Margaritas",
                    Cost = 3,
                    
                    Email = "test2@gmail.com",
                    

                },
                new ParkingSpot
                {
                    Title = "Capital Hill",
                    Size = "small",
                    Location = "Capital Hill",
                    
                    SpecialInstructions = "First Come First Serve",
                    Cost = 5,
                   
                    Email = "test3@gmail.com",
                    

                },
                new ParkingSpot
                {
                    Title = "Everette",
                    Size = "small",
                    Location = "Everette",
                    
                    SpecialInstructions = "YMCA",
                    Cost = 0,
                    
                    Email = "test4@gmail.com",
                    

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
