using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpotParkApi.Models
{
    public class Report
    {
        public long ID { get; set; }
        
        public long ParkingSpotID { get; set; }
        public ParkingSpot ParkingSpot { get; set; }

        [StringLength(200)]
        public string Message { get; set; }


        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
