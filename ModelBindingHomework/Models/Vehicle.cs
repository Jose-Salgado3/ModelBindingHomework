using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBindingHomework.Models
{
    /// <summary>
    /// Represents the vehicle that is to be rented
    /// Full Name is the person that is renting it
    /// </summary>
    public class Vehicle
    {
        /// <summary>
        /// The legal First and Last name of the person wishing to rent a vehicle
        /// </summary>

        [Required]
        [Display(Name = "Full Legal Name")]
        public string FullName { get; set; }
        
        /// <summary>
        /// The name of the company that manufactured the vehicle.
        /// </summary>
        [Required]
        [Display(Name ="Must enter make of vehicle")]
        public string Make { get; set; }

        /// <summary>
        /// The model of the vehicle that is to be rented
        /// </summary>
        [Required]
        [Display(Name ="Must enter model")]
        public string Model { get; set; }


        /// <summary>
        /// The year that the vehicle was manufactured
        /// ex. 1990
        /// </summary>
        [Required]
        public int Year { get; set; }

        /// <summary>
        /// Represents the miles that are on the vehicle at the current time of applying.
        /// </summary>
        [Required]
        public int Miles { get; set; }
    }
}
