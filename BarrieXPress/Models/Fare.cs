using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BarrieXPress.Models
{
    public class Fare
    {
        public int FareId { get; set; }
        [Required]
        [Display(Name = "Passenger")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Fare")]
        public double FareInfo { get; set; }
    }
}