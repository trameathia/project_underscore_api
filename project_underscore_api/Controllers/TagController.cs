using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project_underscore_api.Data;
using project_underscore_api.Models;

namespace project_underscore_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly ProjectUnderscoreContext _context;

        public TagController(ProjectUnderscoreContext context)
        {
            _context = context;
        }

        // GET: api/UserItemTags
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tag>>> GetUserItemTags()
        {
            return await _context.Tags.ToListAsync();
        }

        // GET: api/UserItemTags/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tag>> GetUserItemTag(int id)
        {
            var userItemTag = await _context.Tags.FindAsync(id);

            if (userItemTag == null)
            {
                return NotFound();
            }

            return userItemTag;
        }

        // PUT: api/UserItemTags/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserItemTag(int id, Tag userItemTag)
        {
            if (id != userItemTag.ID)
            {
                return BadRequest();
            }

            _context.Entry(userItemTag).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserItemTagExists(id))
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

        // POST: api/UserItemTags
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tag>> PostUserItemTag(Tag userItemTag)
        {
            _context.Tags.Add(userItemTag);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserItemTag", new { id = userItemTag.ID }, userItemTag);
        }

        // DELETE: api/UserItemTags/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserItemTag(int id)
        {
            var userItemTag = await _context.Tags.FindAsync(id);
            if (userItemTag == null)
            {
                return NotFound();
            }

            _context.Tags.Remove(userItemTag);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserItemTagExists(int id)
        {
            return _context.Tags.Any(e => e.ID == id);
        }
    }
}
