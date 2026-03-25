namespace apbd_cw2.Models;

public class Employee : Uzytkownik
{
    
    public override string Typ => "Pracownik";
    public override int LimitWypozyczen => 5;

    public Employee(string imie, string nazwisko) : base(imie, nazwisko)
    {
    }
    
}