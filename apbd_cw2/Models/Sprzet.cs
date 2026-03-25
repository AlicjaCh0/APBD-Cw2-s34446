namespace apbd_cw2.Models; 

public abstract class Sprzet
{
    
    private static int _nextId = 1;
    
    public string Nazwa { get; set; }
    
    public bool CzyDostepny { get; set; } = true;

    public Sprzet(String nazwa1)
    {
        Nazwa = nazwa1;
    }

}