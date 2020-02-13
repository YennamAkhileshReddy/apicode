using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CILogsDetails.Model;

namespace CILogsDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AzureCilogsController : ControllerBase
    {
        private readonly CILogsDetailContext _context;

        public AzureCilogsController(CILogsDetailContext context)
        {
            _context = context;
        }

        // GET: api/AzureCilogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AzureCilogsDetails>>> GetAzureCilogsDetails()
        {
            return await _context.AzureCilogsDetails.ToListAsync();
        }

        // GET: api/AzureCilogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AzureCilogsDetails>> GetAzureCilogsDetails(int id)
        {
            var azureCilogsDetails = await _context.AzureCilogsDetails.FindAsync(id);

            if (azureCilogsDetails == null)
            {
                return NotFound();
            }

            return azureCilogsDetails;
        }

        // PUT: api/AzureCilogs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAzureCilogsDetails(int id, AzureCilogsDetails azureCilogsDetails)
        {
            if (id != azureCilogsDetails.Id)
            {
                return BadRequest();
            }

            _context.Entry(azureCilogsDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AzureCilogsDetailsExists(id))
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

        // POST: api/AzureCilogs
        [HttpPost]
        public async Task<ActionResult<AzureCilogsDetails>> PostAzureCilogsDetails(AzureCilogsDetails azureCilogsDetails)
        {
            _context.AzureCilogsDetails.Add(azureCilogsDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAzureCilogsDetails", new { id = azureCilogsDetails.Id }, azureCilogsDetails);
        }

        // DELETE: api/AzureCilogs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AzureCilogsDetails>> DeleteAzureCilogsDetails(int id)
        {
            var azureCilogsDetails = await _context.AzureCilogsDetails.FindAsync(id);
            if (azureCilogsDetails == null)
            {
                return NotFound();
            }

            _context.AzureCilogsDetails.Remove(azureCilogsDetails);
            await _context.SaveChangesAsync();

            return azureCilogsDetails;
        }

        private bool AzureCilogsDetailsExists(int id)
        {
            return _context.AzureCilogsDetails.Any(e => e.Id == id);
        }
    }
}
