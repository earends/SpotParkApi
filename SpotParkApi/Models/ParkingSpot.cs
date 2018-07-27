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

        [Display(Name = "Title")]
        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Display(Name = "Size")]
        [Required]
        public double Size { get; set; }

        [Display(Name = "Location")]
        [Required]
        public string Location { get; set; }

        [Display(Name = "Location Identifier")]
        [StringLength(25)]
        public string LocationIdentifier { get; set; }

        [Display(Name = "Speical Instructions")]
        [StringLength(500)]
        public string SpecialInstructions { get; set; }

        [Display(Name = "Cost")]
        [Required]
        public double Cost { get; set; }

        [Display(Name = "Start Date")]
        [Required]
        public DateTime AvailabilityStart { get; set; }

        [Display(Name = "End Date")]
        [Required]
        public DateTime AvailabilityEnd { get; set; }

        [Display(Name = "Email")]
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        
        public int ReportCount { get; set; }

        public ICollection<Report> Reports {get; set;}

        public ParkingSpot()
        {
            ReportCount = 0;
        }
    }
}
