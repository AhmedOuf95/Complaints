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
    public class EmployeeCompNoteController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EmployeeCompNoteController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/EmployeeCompNote
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeCompNote>>> GetEmployeeCompNotes()
        {
            return await _context.EmployeeCompNotes.ToListAsync();
        }

        // GET: api/EmployeeCompNote/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeCompNote>> GetEmployeeCompNote(int id)
        {
            var employeeCompNote = await _context.EmployeeCompNotes.FindAsync(id);

            if (employeeCompNote == null)
            {
                return NotFound();
            }

            return employeeCompNote;
        }

        // PUT: api/EmployeeCompNote/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployeeCompNote(int id, EmployeeCompNote employeeCompNote)
        {
            if (id != employeeCompNote.EmpCompNoteId)
            {
                return BadRequest();
            }

            _context.Entry(employeeCompNote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeCompNoteExists(id))
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

        // POST: api/EmployeeCompNote
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EmployeeCompNote>> PostEmployeeCompNote(EmployeeCompNote employeeCompNote)
        {
            _context.EmployeeCompNotes.Add(employeeCompNote);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployeeCompNote", new { id = employeeCompNote.EmpCompNoteId }, employeeCompNote);
        }

        // DELETE: api/EmployeeCompNote/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeeCompNote(int id)
        {
            var employeeCompNote = await _context.EmployeeCompNotes.FindAsync(id);
            if (employeeCompNote == null)
            {
                return NotFound();
            }

            _context.EmployeeCompNotes.Remove(employeeCompNote);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployeeCompNoteExists(int id)
        {
            return _context.EmployeeCompNotes.Any(e => e.EmpCompNoteId == id);
        }
    }
}
