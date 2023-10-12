using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Zgapari;


namespace Zgapari.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZgaparisController : ControllerBase
    {
        private readonly dbzContext _context;

        public ZgaparisController(dbzContext context)
        {
            _context = context;
        }

        // GET: api/Zgaparis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Zgapari>>> GetPosts()
        {
            if (_context.Zgaprebi == null)
            {
                return NotFound();
            }
            return await _context.Zgaprebi.ToListAsync();
        }

        // GET: api/Zgaparis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Zgapari>> GetZgapari(int id)
        {
            if (_context.Zgaprebi == null)
            {
                return NotFound();
            }
            var zgapari = await _context.Zgaprebi    .FindAsync(id);

            if (zgapari == null)
            {
                return NotFound();
            }

            return zgapari;
        }

        // PUT: api/Zgaparis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutZgapari(int id, Zgapari zgapari)
        {
            if (id != zgapari.ZgapariId)
            {
                return BadRequest();
            }

            _context.Entry(zgapari).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZgapariExists(id))
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

        // POST: api/Zgaparis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Zgapari>> PostZgapari(DTOZgapari zgapari0)
        {
            Zgapari zgapari = new Zgapari();
            zgapari.Title = zgapari0.Title;
            zgapari.Content = zgapari0.Content;


            if (_context.Zgaprebi == null)
            {
                return Problem("Entity set 'db2Context.Posts'  is null.");
            }
            _context.Zgaprebi.Add(zgapari);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetZgapari", new { id = zgapari.ZgapariId }, zgapari);
        }

        // DELETE: api/Zgaparis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteZgapari(int id)
        {
            if (_context.Zgaprebi == null)
            {
                return NotFound();
            }
            var zgapari = await _context.Zgaprebi.FindAsync(id);
            if (zgapari == null)
            {
                return NotFound();
            }

            _context.Zgaprebi.Remove(zgapari);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ZgapariExists(int id)
        {
            return (_context.Zgaprebi?.Any(e => e.ZgapariId == id)).GetValueOrDefault();
        }
    }
}
