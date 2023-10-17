namespace Zgapari
{
    public interface IZgapari
    {
        List<Zgapari> GetZgaprebi();
        Zgapari GetZgapari(int id);
        Zgapari CreateZgapari(DTOZgapari zgapari0);
        Zgapari UpdateZgapari(int id, Zgapari zgapari);
        bool DeleteZgapari(int id);

         
        
    }
}
