using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpotParkApi.Models
{
    public class ParkingSpot
    {
        public long ID { get; set; }

        [Required]
        [StringLength(50)] 
        public string Title { get; set; }


        [Required]
        public double Size { get; set; }


        [Required]
        public string Location { get; set; }


        [StringLength(25)]
        public string LocationIdentifier { get; set; }


        [StringLength(500)]
        public string SpecialInstructions { get; set; }

       
        [Required]
        public double Cost { get; set; }


        [Required]
        public DateTime AvailabilityStart { get; set; }

        
        [Required]
        public DateTime AvailabilityEnd { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}
