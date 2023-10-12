using Microsoft.EntityFrameworkCore;

namespace Zgapari
{
    public class ZgapariSV : IZgapari
    {
        private readonly dbzContext _context;

        public ZgapariSV(dbzContext context)
        {
            _context = context;
        }

        public Zgapari CreateZgapari(DTOZgapari zgapari0)
        {
            throw new NotImplementedException();
        }

        public bool DeleteZgapari(int id)
        {
            throw new NotImplementedException();
        }

        public Zgapari GetZgapari(int id)
        {
            if (_context.Zgaprebi == null)
            {
                return null;
            }
            var zgapari = _context.Zgaprebi.Find(id);

            if (zgapari == null)
            {
                return null;
            }

            return zgapari;
        }

        public List<Zgapari> GetZgaprebi()
        {
            if (_context.Zgaprebi == null)
            {
                return null;
            }
            return  _context.Zgaprebi.ToList();
        }

        public Zgapari UpdateZgapari(int id, Zgapari zgapari)
        {
            throw new NotImplementedException();
        }
    }
}
