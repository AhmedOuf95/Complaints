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
    public class ComplaintStatusController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ComplaintStatusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ComplaintStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComplaintStatus>>> GetComplaintStatuses()
        {
            return await _context.ComplaintStatuses.ToListAsync();
        }

        // GET: api/ComplaintStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ComplaintStatus>> GetComplaintStatus(int id)
        {
            var complaintStatus = await _context.ComplaintStatuses.FindAsync(id);

            if (complaintStatus == null)
            {
                return NotFound();
            }

            return complaintStatus;
        }

        // PUT: api/ComplaintStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComplaintStatus(int id, ComplaintStatus complaintStatus)
        {
            if (id != complaintStatus.CompStatusID)
            {
                return BadRequest();
            }

            _context.Entry(complaintStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComplaintStatusExists(id))
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

        // POST: api/ComplaintStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ComplaintStatus>> PostComplaintStatus(ComplaintStatus complaintStatus)
        {
            _context.ComplaintStatuses.Add(complaintStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComplaintStatus", new { id = complaintStatus.CompStatusID }, complaintStatus);
        }

        // DELETE: api/ComplaintStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComplaintStatus(int id)
        {
            var complaintStatus = await _context.ComplaintStatuses.FindAsync(id);
            if (complaintStatus == null)
            {
                return NotFound();
            }

            _context.ComplaintStatuses.Remove(complaintStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ComplaintStatusExists(int id)
        {
            return _context.ComplaintStatuses.Any(e => e.CompStatusID == id);
        }
    }
}
