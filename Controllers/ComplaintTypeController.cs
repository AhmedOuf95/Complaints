using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Complaints.Data;
using Complaints.Models;

namespace Complaints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplaintTypeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ComplaintTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ComplaintType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComplaintType>>> GetComplaintTypes()
        {
            return await _context.ComplaintTypes.ToListAsync();
        }

        // GET: api/ComplaintType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ComplaintType>> GetComplaintType(int id)
        {
            var complaintType = await _context.ComplaintTypes.FindAsync(id);

            if (complaintType == null)
            {
                return NotFound();
            }

            return complaintType;
        }

        // PUT: api/ComplaintType/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComplaintType(int id, ComplaintType complaintType)
        {
            if (id != complaintType.CompTypeId)
            {
                return BadRequest();
            }

            _context.Entry(complaintType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComplaintTypeExists(id))
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

        // POST: api/ComplaintType
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ComplaintType>> PostComplaintType(ComplaintType complaintType)
        {
            _context.ComplaintTypes.Add(complaintType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComplaintType", new { id = complaintType.CompTypeId }, complaintType);
        }

        // DELETE: api/ComplaintType/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComplaintType(int id)
        {
            var complaintType = await _context.ComplaintTypes.FindAsync(id);
            if (complaintType == null)
            {
                return NotFound();
            }

            _context.ComplaintTypes.Remove(complaintType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ComplaintTypeExists(int id)
        {
            return _context.ComplaintTypes.Any(e => e.CompTypeId == id);
        }
    }
}
