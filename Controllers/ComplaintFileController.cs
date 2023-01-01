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
    public class ComplaintFileController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ComplaintFileController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ComplaintFile
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComplaintFile>>> GetComplaintFiles()
        {
            return await _context.ComplaintFiles.ToListAsync();
        }

        // GET: api/ComplaintFile/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ComplaintFile>> GetComplaintFile(int id)
        {
            var complaintFile = await _context.ComplaintFiles.FindAsync(id);

            if (complaintFile == null)
            {
                return NotFound();
            }

            return complaintFile;
        }

        // PUT: api/ComplaintFile/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComplaintFile(int id, ComplaintFile complaintFile)
        {
            if (id != complaintFile.CompFileId)
            {
                return BadRequest();
            }

            _context.Entry(complaintFile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComplaintFileExists(id))
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

        // POST: api/ComplaintFile
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ComplaintFile>> PostComplaintFile(ComplaintFile complaintFile)
        {
            _context.ComplaintFiles.Add(complaintFile);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComplaintFile", new { id = complaintFile.CompFileId }, complaintFile);
        }

        // DELETE: api/ComplaintFile/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComplaintFile(int id)
        {
            var complaintFile = await _context.ComplaintFiles.FindAsync(id);
            if (complaintFile == null)
            {
                return NotFound();
            }

            _context.ComplaintFiles.Remove(complaintFile);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ComplaintFileExists(int id)
        {
            return _context.ComplaintFiles.Any(e => e.CompFileId == id);
        }
    }
}
