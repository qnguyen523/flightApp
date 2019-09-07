using System;
using System.ComponentModel.DataAnnotations;

namespace flightApp.Models
{
    public class Flight
    {
        public int ID { get; set; }
        [Display(Name = "Departure")]
        public string departure { get; set; }
        [Display(Name = "Destination")]
        public string destination { get; set; }

        [Display(Name = "Departure Date")]
        [DataType(DataType.DateTime)]
        public DateTime departureTime { get; set; }
        [Display(Name = "Arrival Date")]
        [DataType(DataType.DateTime)]
        public DateTime arrivalTime { get; set; }
        public string Class { get; set; }
        public decimal Price { get; set; }
    }
}
