using System;
using System.ComponentModel.DataAnnotations;

namespace flightApp.Models
{
    public class Flight
    {
        public int ID { get; set; }
        public string departure { get; set; }
        public string destination { get; set; }

        [DataType(DataType.Date)]
        public DateTime departureTime { get; set; }
        [DataType(DataType.Date)]
        public DateTime arrivalTime { get; set; }
        public string Class { get; set; }
        public decimal Price { get; set; }
    }
}
