namespace apbd_cw2.Models;

public class Wypozyczenie
{
    private static int _nextId = 1;
    public int Id { get; private set; } = _nextId++;
    
    public Uzytkownik KtoWypozycza { get; private set; }
    public Sprzet WypozyczonySprzet { get; private set; }
    
    public DateTime DataWypozyczenia { get; private set; }
    public DateTime KiedyZwrot { get; private set; }
    
    public DateTime? DataFaktycznegoZwrotu { get; private set; } 
    
    //? - null
    
    public Wypozyczenie(Uzytkownik Osoba, Sprzet sprzet, int IleDni)
    {
        KtoWypozycza = Osoba;
        
        WypozyczonySprzet = sprzet;
        
        DataWypozyczenia = DateTime.Now;
        
        KiedyZwrot = DateTime.Now.AddDays(IleDni);
    }


    public void OznaczZwrocone()
    {
        DataFaktycznegoZwrotu = DateTime.Now;
    }
}