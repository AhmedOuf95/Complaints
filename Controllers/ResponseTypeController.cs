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
    public class ResponseTypeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ResponseTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ResponseType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseType>>> GetResponseTypes()
        {
            return await _context.ResponseTypes.ToListAsync();
        }

        // GET: api/ResponseType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseType>> GetResponseType(int id)
        {
            var responseType = await _context.ResponseTypes.FindAsync(id);

            if (responseType == null)
            {
                return NotFound();
            }

            return responseType;
        }

        // PUT: api/ResponseType/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResponseType(int id, ResponseType responseType)
        {
            if (id != responseType.RespTypeId)
            {
                return BadRequest();
            }

            _context.Entry(responseType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResponseTypeExists(id))
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

        // POST: api/ResponseType
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ResponseType>> PostResponseType(ResponseType responseType)
        {
            _context.ResponseTypes.Add(responseType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetResponseType", new { id = responseType.RespTypeId }, responseType);
        }

        // DELETE: api/ResponseType/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResponseType(int id)
        {
            var responseType = await _context.ResponseTypes.FindAsync(id);
            if (responseType == null)
            {
                return NotFound();
            }

            _context.ResponseTypes.Remove(responseType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ResponseTypeExists(int id)
        {
            return _context.ResponseTypes.Any(e => e.RespTypeId == id);
        }
    }
}
