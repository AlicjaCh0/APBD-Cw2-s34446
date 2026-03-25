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
    
    
    
    public void ZwrotSprzetu(Uzytkownik uzytkownik, Sprzet sprzet)
    {
        Wypozyczenie znalezioneWypozyczenie = null;

        for (int i = 0; i < _wypozyczone.Count; i++)
        {
            Wypozyczenie w = _wypozyczone[i];
            
            if (w.KtoWypozycza.Id == uzytkownik.Id && w.WypozyczonySprzet.Id == sprzet.Id && w.DataFaktycznegoZwrotu == null)
            {
                znalezioneWypozyczenie = w;
                break;
            }
        }

        if (znalezioneWypozyczenie == null)
        {
            Console.WriteLine("Podany użytkownik nie wypożyczył tego sprzętu");
            return;
        }


        sprzet.CzyDostepny = true;
        
        znalezioneWypozyczenie.OznaczZwrocone();

        TimeSpan roznica = znalezioneWypozyczenie.DataFaktycznegoZwrotu.Value - znalezioneWypozyczenie.KiedyZwrot;

        int dniOpoznienia = (int)roznica.TotalDays;
        
        if (dniOpoznienia > 0)
        {
            int kara = dniOpoznienia * 35 + 21; 
            
            Console.WriteLine($"Po terminie! Dni spóźnienia: {dniOpoznienia}. KARA: {kara} PLN.");
        }
        else
        {
            Console.WriteLine($"{uzytkownik.Imie} zwrócił {sprzet.Nazwa} w terminie.");
        }
    }
    
    
    public void DostepnySprzet()
    {
        Console.WriteLine("\nraport:");
        
        for (int i = 0; i < _sprzety.Count; i++)
        {
            Sprzet s = _sprzety[i];
            
            string status = s.CzyDostepny ? "Dostępny" : "Niedostępny";
            
            Console.WriteLine($"Dane o sprzecie: {s.Id} | {s.Nazwa} | {status}");
        }
    }

    
    public void WypozyczeniaUzytkownika(Uzytkownik u)
    {
        Console.WriteLine($"\nwypozyczenia uzytkownika: {u.Imie} {u.Nazwisko}");
        
        for (int i = 0; i < _wypozyczone.Count; i++)
        {
           
            Wypozyczenie w = _wypozyczone[i];
            
            if (w.KtoWypozycza.Id == u.Id && w.DataFaktycznegoZwrotu == null)
            {
                
                Console.WriteLine($"- {w.WypozyczonySprzet.Nazwa} (Termin: {w.KiedyZwrot.ToShortDateString()})");
                
            }
        }
    }

}