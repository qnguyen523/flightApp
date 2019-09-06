using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using flightApp.Models;

namespace flightApp.Pages.Flights
{
    public class IndexModel : PageModel
    {
        private readonly flightApp.Models.FlightContext _context;

        public IndexModel(flightApp.Models.FlightContext context)
        {
            _context = context;
        }

        public IList<Flight> Flight { get;set; }

        public async Task OnGetAsync()
        {
            Flight = await _context.flight.ToListAsync();
        }
    }
}
