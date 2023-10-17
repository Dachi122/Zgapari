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
        

            return _izgapari.GetZgaprebi();

        }




        // GET: api/Zgaparis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Zgapari>> GetZgapari(int id)
        {
          
            return _izgapari.GetZgapari(id);
        }




        // PUT: api/Zgaparis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutZgapari(int id, Zgapari zgapari)
        {
           
            return Ok(_izgapari.UpdateZgapari(id, zgapari));
        }





        // POST: api/Zgaparis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Zgapari>> PostZgapari(DTOZgapari zgapari0)
        {
         
            return _izgapari.CreateZgapari(zgapari0);
        }





        // DELETE: api/Zgaparis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteZgapari(int id)
        {
            
            return Ok(_izgapari.DeleteZgapari(id));
        }

       
    }
}
