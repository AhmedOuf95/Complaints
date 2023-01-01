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
    public class ComplaintTypeContactController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ComplaintTypeContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ComplaintTypeContact
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComplaintTypeContact>>> GetComplaintTypeContacts()
        {
            return await _context.ComplaintTypeContacts.ToListAsync();
        }

        // GET: api/ComplaintTypeContact/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ComplaintTypeContact>> GetComplaintTypeContact(int id)
        {
            var complaintTypeContact = await _context.ComplaintTypeContacts.FindAsync(id);

            if (complaintTypeContact == null)
            {
                return NotFound();
            }

            return complaintTypeContact;
        }

        // PUT: api/ComplaintTypeContact/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComplaintTypeContact(int id, ComplaintTypeContact complaintTypeContact)
        {
            if (id != complaintTypeContact.CompTypeContactID)
            {
                return BadRequest();
            }

            _context.Entry(complaintTypeContact).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComplaintTypeContactExists(id))
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

        // POST: api/ComplaintTypeContact
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ComplaintTypeContact>> PostComplaintTypeContact(ComplaintTypeContact complaintTypeContact)
        {
            _context.ComplaintTypeContacts.Add(complaintTypeContact);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ComplaintTypeContactExists(complaintTypeContact.CompTypeContactID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetComplaintTypeContact", new { id = complaintTypeContact.CompTypeContactID }, complaintTypeContact);
        }

        // DELETE: api/ComplaintTypeContact/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComplaintTypeContact(int id)
        {
            var complaintTypeContact = await _context.ComplaintTypeContacts.FindAsync(id);
            if (complaintTypeContact == null)
            {
                return NotFound();
            }

            _context.ComplaintTypeContacts.Remove(complaintTypeContact);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ComplaintTypeContactExists(int id)
        {
            return _context.ComplaintTypeContacts.Any(e => e.CompTypeContactID == id);
        }
    }
}
