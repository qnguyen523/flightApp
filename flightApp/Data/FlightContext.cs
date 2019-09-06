using Microsoft.EntityFrameworkCore;

namespace flightApp.Models
{
    public class FlightContext : DbContext
    {
        public FlightContext(DbContextOptions<FlightContext> options)
            : base(options)
        {

        }
        public DbSet<flightApp.Models.Flight> flight { get; set; }
    }
}