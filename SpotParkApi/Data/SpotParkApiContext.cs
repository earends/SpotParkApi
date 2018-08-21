using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SpotParkApi.Models
{
    public class SpotParkApiContext : DbContext
    {
        public SpotParkApiContext (DbContextOptions<SpotParkApiContext> options)
            : base(options)
        {
        }

        public DbSet<SpotParkApi.Models.ParkingSpot> ParkingSpot { get; set; }
        
    }
}
