using Microsoft.AspNetCore.Mvc;

namespace Zgapari.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZgaparisController : ControllerBase
    {
        //private readonly dbzContext _context;
        private readonly IZgapari _izgapari;

        public ZgaparisController(IZgapari izgapari)
        {
            //_context = context;
            _izgapari = izgapari;
        }

        // GET: api/Zgaparis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Zgapari>>> GetZgaprebi()
        {
         // if (_context.Zgaprebi == null)
         // {
         //     return NotFound();
         // } 
         //   return await _context.Zgaprebi.ToListAsync();

            return _izgapari.GetZgaprebi();

        }

        // GET: api/Zgaparis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Zgapari>> GetZgapari(int id)
        {
          //if (_context.Zgaprebi == null)
          //{
          //    return NotFound();
          //}
          //  var zgapari = await _context.Zgaprebi.FindAsync(id);

          //  if (zgapari == null)
          //  {
          //      return NotFound();
          //  }

          //  return zgapari;

            return _izgapari.GetZgapari(id);
        }

        // PUT: api/Zgaparis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutZgapari(int id, Zgapari zgapari)
        {
            //if (id != zgapari.ZgapariId)
            //{
            //    return BadRequest();
            //}

            //_context.Entry(zgapari).State = EntityState.Modified;

            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!ZgapariExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            return Ok(_izgapari.UpdateZgapari(id, zgapari));
        }

        // POST: api/Zgaparis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Zgapari>> PostZgapari(DTOZgapari zgapari0)
        {
          //if (_context.Zgaprebi == null)
          //{
          //    return Problem("Entity set 'dbzContext.Zgaprebi'  is null.");
          //}

          //Zgapari zgapari = new Zgapari();
          //  zgapari.Title = zgapari0.Title;
          //  zgapari.Content = zgapari0.Content;


          //  _context.Zgaprebi.Add(zgapari);
          //  await _context.SaveChangesAsync();

         //  return CreatedAtAction("GetZgapari", new { id = zgapari.ZgapariId }, zgapari);

            return _izgapari.CreateZgapari(zgapari0);
        }

        // DELETE: api/Zgaparis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteZgapari(int id)
        {
            //if (_context.Zgaprebi == null)
            //{
            //    return NotFound();
            //}
            //var zgapari = await _context.Zgaprebi.FindAsync(id);
            //if (zgapari == null)
            //{
            //    return NotFound();
            //}

            //_context.Zgaprebi.Remove(zgapari);
            //await _context.SaveChangesAsync();

            return Ok(_izgapari.DeleteZgapari(id));
        }

       
    }
}
