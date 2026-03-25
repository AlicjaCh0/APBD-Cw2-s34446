namespace apbd_cw2.Models;

public class Student : Uzytkownik
{
    public override string Typ => "Student";

    public override int LimitWypozyczen => 2;
    

    public Student(string imie, string nazwisko) : base(imie, nazwisko)
    {
    }
}