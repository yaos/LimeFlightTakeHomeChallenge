using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LimeFlightTakeHomeChallenge.DAL;
using LimeFlightTakeHomeChallenge.DAL.Models;

namespace LimeFlightTakeHomeChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FlightsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Flights
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Flight>>> GetFlights(DateTime? filterStartDateUTC, DateTime? filterEndDateUTC)
        {
            return await _context.Flights.Where(x => (filterStartDateUTC == null || x.Std >= filterStartDateUTC) &&
                                      (filterEndDateUTC == null || x.Std <= filterEndDateUTC)).ToListAsync();
        }

        // GET: api/Flights/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Flight>> GetFlights(int id)
        {
            var flights = await _context.Flights.FindAsync(id);

            if (flights == null)
            {
                return NotFound();
            }

            return flights;
        }

        // PUT: api/Flights/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlights(int id, Flight flights)
        {
            if (id != flights.Id)
            {
                return BadRequest();
            }

            _context.Entry(flights).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FlightsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Flights
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Flight>> PostFlights(Flight flights)
        {
            _context.Flights.Add(flights);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFlights", new { id = flights.Id }, flights);
        }

        // DELETE: api/Flights/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFlights(int id)
        {
            var flights = await _context.Flights.FindAsync(id);
            if (flights == null)
            {
                return NotFound();
            }

            _context.Flights.Remove(flights);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FlightsExists(int id)
        {
            return _context.Flights.Any(e => e.Id == id);
        }
    }
}
