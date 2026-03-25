namespace apbd_cw2.Models;

public class Student : Uzytkownik
{
    public override string Typ => "Student";

    public override int LimitWypozyczen { get; }

    public Student(string imie, string nazwisko) : base(imie, nazwisko)
    {
    }
}