namespace apbd_cw2.Models;

public abstract class Uzytkownik
{
    
    private static int _nextId = 1;
    
    public int Id { get; set; } = _nextId++;
    
    public string Imie { get; set; }
    
    public string Nazwisko { get; set; }
    
    public abstract int LimitWypozyczen { get; }
    public abstract string Typ { get; }

    protected Uzytkownik(string imie, string nazwisko)
    {
        Imie = imie;
        Nazwisko = nazwisko;
    }
    
}