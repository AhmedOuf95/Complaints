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
    public class EmployeeComplaintController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EmployeeComplaintController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/EmployeeComplaint
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeComplaint>>> GetEmployeeComplaints()
        {
            return await _context.EmployeeComplaints.ToListAsync();
        }

        // GET: api/EmployeeComplaint/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeComplaint>> GetEmployeeComplaint(int id)
        {
            var employeeComplaint = await _context.EmployeeComplaints.FindAsync(id);

            if (employeeComplaint == null)
            {
                return NotFound();
            }

            return employeeComplaint;
        }

        // PUT: api/EmployeeComplaint/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployeeComplaint(int id, EmployeeComplaint employeeComplaint)
        {
            if (id != employeeComplaint.EmpId)
            {
                return BadRequest();
            }

            _context.Entry(employeeComplaint).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeComplaintExists(id))
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

        // POST: api/EmployeeComplaint
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EmployeeComplaint>> PostEmployeeComplaint(EmployeeComplaint employeeComplaint)
        {
            _context.EmployeeComplaints.Add(employeeComplaint);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EmployeeComplaintExists(employeeComplaint.EmpId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEmployeeComplaint", new { id = employeeComplaint.EmpId }, employeeComplaint);
        }

        // DELETE: api/EmployeeComplaint/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeeComplaint(int id)
        {
            var employeeComplaint = await _context.EmployeeComplaints.FindAsync(id);
            if (employeeComplaint == null)
            {
                return NotFound();
            }

            _context.EmployeeComplaints.Remove(employeeComplaint);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployeeComplaintExists(int id)
        {
            return _context.EmployeeComplaints.Any(e => e.EmpId == id);
        }
    }
}
