


using apbd_cw2.Models;
using apbd_cw2.Services;

Console.WriteLine("Witam w naszej wypożyczalni");


WypozyczalniaDzialanie wypozyczalnia = new WypozyczalniaDzialanie();

Projektor projektor = new Projektor("Projektor Samsung","4k ultra HD",2000);

Laptop lenovo = new Laptop("Lenovo", 32, "M21");

Laptop dell = new Laptop("Dell", 32, "Intel i37");

Kamera kamera = new Kamera("Kamera LG",true,"karta");



wypozyczalnia.DodajSprzet(lenovo);
wypozyczalnia.DodajSprzet(dell);
wypozyczalnia.DodajSprzet(kamera);
wypozyczalnia.DodajSprzet(projektor);


Student stPawel = new Student("Pawel", "Stanczyk");
Employee emStefan = new Employee("Stefan", "Puć");
Employee emJoanta = new Employee("Jolanta", "Czas");


wypozyczalnia.DodajUzytkownika(stPawel);
wypozyczalnia.DodajUzytkownika(emStefan);

wypozyczalnia.DodajUzytkownika(emJoanta);

Console.WriteLine("\nJolanta 2 dni sprzet: dell");

wypozyczalnia.WypozyczenieSprzetu(emJoanta, dell, 2);


Console.WriteLine("\nPawel 1 dzien sprzet: dell");

wypozyczalnia.WypozyczenieSprzetu(stPawel, dell, 1);


Console.WriteLine("\nPawel bierze wiecej sprzetow niz moze");

Laptop macbook3 = new Laptop("pro", 8, "Intel");
Laptop macbook2 = new Laptop("pro2", 8, "Intel");
wypozyczalnia.DodajSprzet(macbook3);
wypozyczalnia.DodajSprzet(macbook2);

wypozyczalnia.WypozyczenieSprzetu(stPawel, macbook2, 5);
wypozyczalnia.WypozyczenieSprzetu(stPawel, macbook3, 2);

Laptop kolejnyLaptop = new Laptop("Asus", 16, "Intel");
wypozyczalnia.DodajSprzet(kolejnyLaptop);

wypozyczalnia.WypozyczenieSprzetu(stPawel, kolejnyLaptop, 2); 


Console.WriteLine("\nJolanta oddaje Della:");
wypozyczalnia.ZwrotSprzetu(emJoanta, dell);

Console.WriteLine("\nkoniec");