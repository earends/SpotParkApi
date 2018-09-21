using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpotParkApi.Models;

namespace SpotParkApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingSpotsController : ControllerBase
    {
        private readonly SpotParkApiContext _context;

        public ParkingSpotsController(SpotParkApiContext context)
        {
            _context = context;
        }
        //new change
        // GET: api/ParkingSpots
        [HttpGet]
        public IEnumerable<ParkingSpot> GetParkingSpot()
        {
            return _context.ParkingSpot;
        }

        // GET: api/ParkingSpots/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetParkingSpot([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var parkingSpot = await _context.ParkingSpot.FindAsync(id);

            if (parkingSpot == null)
            {
                return NotFound();
            }

            return Ok(parkingSpot);
        }

        // PUT: api/ParkingSpots/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutParkingSpot([FromRoute] long id, [FromBody] ParkingSpot parkingSpot)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != parkingSpot.ID)
            {
                return BadRequest();
            }

            _context.Entry(parkingSpot).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParkingSpotExists(id))
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

        // POST: api/ParkingSpots
        [HttpPost]
        public async Task<IActionResult> PostParkingSpot([FromBody] ParkingSpot parkingSpot)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ParkingSpot.Add(parkingSpot);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetParkingSpot", new { id = parkingSpot.ID }, parkingSpot);
        }

        // DELETE: api/ParkingSpots/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteParkingSpot([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var parkingSpot = await _context.ParkingSpot.FindAsync(id);
            if (parkingSpot == null)
            {
                return NotFound();
            }

            _context.ParkingSpot.Remove(parkingSpot);
            await _context.SaveChangesAsync();

            return Ok(parkingSpot);
        }

        private bool ParkingSpotExists(long id)
        {
            return _context.ParkingSpot.Any(e => e.ID == id);
        }
    }
}