using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BarrieXPress.Models
{
    public class Route
    {
        public int RouteId { get; set; }
        [Required]
        [Display(Name = "Stop Name")]
        public string Name { get; set; }
        [Required]
        public double Distance { get; set; }
    }
}