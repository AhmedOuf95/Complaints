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
    public class JobTitleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public JobTitleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/JobTitle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobTitle>>> GetJobTitles()
        {
            return await _context.JobTitles.ToListAsync();
        }

        // GET: api/JobTitle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JobTitle>> GetJobTitle(int id)
        {
            var jobTitle = await _context.JobTitles.FindAsync(id);

            if (jobTitle == null)
            {
                return NotFound();
            }

            return jobTitle;
        }

        // PUT: api/JobTitle/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJobTitle(int id, JobTitle jobTitle)
        {
            if (id != jobTitle.JobTitleId)
            {
                return BadRequest();
            }

            _context.Entry(jobTitle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobTitleExists(id))
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

        // POST: api/JobTitle
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JobTitle>> PostJobTitle(JobTitle jobTitle)
        {
            _context.JobTitles.Add(jobTitle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJobTitle", new { id = jobTitle.JobTitleId }, jobTitle);
        }

        // DELETE: api/JobTitle/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJobTitle(int id)
        {
            var jobTitle = await _context.JobTitles.FindAsync(id);
            if (jobTitle == null)
            {
                return NotFound();
            }

            _context.JobTitles.Remove(jobTitle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JobTitleExists(int id)
        {
            return _context.JobTitles.Any(e => e.JobTitleId == id);
        }
    }
}
