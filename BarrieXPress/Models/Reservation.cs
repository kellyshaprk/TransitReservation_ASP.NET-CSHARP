using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BarrieXPress.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        [Required]
        public string MemberId { get; set; }
        [Required]
        [Range(1, 7)]
        public int Departure { get; set; }
        [Required]
        [Range(1, 7)]
        public int Arrival { get; set; }
        [Required]
        [Display(Name = "Date (YYYY-MM-DD)")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }
    }
}