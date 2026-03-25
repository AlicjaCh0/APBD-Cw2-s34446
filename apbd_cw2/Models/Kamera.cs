namespace apbd_cw2.Models;

public class Kamera : Sprzet
{
    public bool CzyMaLampe { get; set; }
    public string ModelKarty { get; set; }

    public Kamera(string nazwa, bool lampa, string karta) : base(nazwa)
    {
        CzyMaLampe = lampa;
        ModelKarty = karta;
    }
}