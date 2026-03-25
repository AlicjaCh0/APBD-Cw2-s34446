namespace apbd_cw2.Models;

public class Laptop : Sprzet
{
    public int RamGb { get; set; }
    public string Procesor { get; set; }
    
    public bool CzyDostepny { get; set; } = true;


    public Laptop(string nazwa,int ramgb,string procesor) : base(nazwa)
    {
        RamGb = ramgb;
        Procesor = procesor;
        
    }

}