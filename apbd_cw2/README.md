System Wypożyczalni Sprzętu - APBD Ćwiczenia 2

Aplikacja przedswtawia działanie wypożyczalni sprzętu.

Uruchomienie:

Otwórz projekt w środowisku np JetBrains Rider
Uruchom projekt (plik `Program.cs` tutaj testowany jest program). W konsoli pojawi sie scenariusz testowy prezentujący działanie logiki biznesowej.


Architektura:


* Models: Zawiera wyłącznie struktury danych np klasa `Pracownik`.
* Services: Klasy odpowiadające za logikę (np. `WypozyczalniaDzialanie`).
* Program.cs: Reprezentacja, pokazuje dzialanie programu na konsoli.

Dziedziczenie:

Mamy 2 klasy abstrakcyjne `Sprzet` oraz `Uzytkownik`. Klasy dziedziczące (np. `Laptop`, `Kamera`, `Student`, `Employee`) posiadają swoje specyficzne właściwości.
Dzięki temu unikamy duplikacji kodu (np `Id`).

Kohezja:

Przyklady w moim projekcie
* Klasa `Wypozyczenie` zajmuje się tylko przetrzymywaniem informacji o datach i powiązaniach obiektów.
* Klasa `WypozyczalniaDzialanie` zajmuje się tylko operacjami takimi jak np. wypożyczanie, zwroty. 
Nie zajmuje się np wyswietlaniem info w konsoli

Coupling
Mała zaleznosc między klasami. 
`WypozyczalniaDzialanie` w metodach `WypozyczenieSprzetu` i `ZwrotSprzetu` bazuje na klasach bazowych (`Uzytkownik`, `Sprzet`), 
a nie na implementacjach (`Student`, `Laptop`).
