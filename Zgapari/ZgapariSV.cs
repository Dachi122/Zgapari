using Microsoft.AspNetCore.Mvc;
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
            if (_context.Zgaprebi == null)
            {
                return null;
            }

            Zgapari zgapari = new Zgapari();
            zgapari.Title = zgapari0.Title;
            zgapari.Content = zgapari0.Content;

            _context.Zgaprebi.Add(zgapari);

            _context.SaveChanges();


            return zgapari;
        }

        public bool DeleteZgapari(int id)
        {
                if (_context.Zgaprebi == null)
                {
                    return false;
                }
                var zgapari = _context.Zgaprebi.Find(id);

                if (zgapari == null)
                {
                    return false;
                }

                         
            _context.Zgaprebi.Remove(zgapari);
            _context.SaveChanges();

            return true;
            
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
            if (id != zgapari.ZgapariId)
            {
                return null;
            }

            _context.Entry(zgapari).State = EntityState.Modified;

            try
            {
                  _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZgapariExists(id))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }

            return zgapari;
        }

        private bool ZgapariExists(int id)
        {
            return (_context.Zgaprebi?.Any(e => e.ZgapariId == id)).GetValueOrDefault();
        }
    }
}
