namespace apbd_cw2.Models;

public class Projektor : Sprzet
{
    public string Rozdzielczosc { get; set; }
    public int Jasnosc { get; set; }

    public Projektor(string nazwa, string rozdzielczosc, int jasnosc) : base(nazwa)
    {
        Rozdzielczosc = rozdzielczosc;
        Jasnosc = jasnosc;
    }
}