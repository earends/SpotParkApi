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
        [StringLength(10)]
        public String Size { get; set; }

        [Display(Name = "Location")]
        [Required]
        public string Location { get; set; }

        [Display(Name = "Speical Instructions")]
        [StringLength(500)]
        public string SpecialInstructions { get; set; }

        [Display(Name = "Cost")]
        [Required]
        public double Cost { get; set; }


        [Display(Name = "Email")]
        [EmailAddress]
        [Required]
        public string Email { get; set; }

       

        
        
    }
}
