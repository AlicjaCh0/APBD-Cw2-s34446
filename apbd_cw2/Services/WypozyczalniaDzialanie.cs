using apbd_cw2.Models;

namespace apbd_cw2.Services;

public class WypozyczalniaDzialanie
{

    private List<Uzytkownik> _uzytkownicy = new List<Uzytkownik>();
    
    private List<Sprzet> _sprzety = new List<Sprzet>();
    
    private List<Wypozyczenie> _wypozyczone = new List<Wypozyczenie>();



    public void DodajUzytkownika(Uzytkownik u) => _uzytkownicy.Add(u);

    public void DodajSprzet(Sprzet s) => _sprzety.Add(s);


    public void WypozyczenieSprzetu(Uzytkownik uzytkownik, Sprzet sprzet, int naIle)
    {
        if (!sprzet.CzyDostepny)
        {
            Console.WriteLine($"Sprzęt {sprzet.Nazwa} jest już wypożyczony");
            return;


        }

        int aktywneWypozyczenia = 0;


        for (int i = 0; i < _wypozyczone.Count; i++)
        {
            Wypozyczenie w = _wypozyczone[i];

            if (w.KtoWypozycza.Id == uzytkownik.Id && w.DataFaktycznegoZwrotu == null)
            {
                aktywneWypozyczenia++;
            }
        }



        if (aktywneWypozyczenia >= uzytkownik.LimitWypozyczen)
        {
            Console.WriteLine(
                $"Użytkownik {uzytkownik.Imie} ma max wypozyczen ({uzytkownik.LimitWypozyczen})!");
            return;
        }

        var noweWypozyczenie = new Wypozyczenie(uzytkownik, sprzet, naIle);
        _wypozyczone.Add(noweWypozyczenie);

        sprzet.CzyDostepny = false;
        Console.WriteLine($"{uzytkownik.Imie} wypożyczył {sprzet.Nazwa} na {naIle} dni.");

    }

}