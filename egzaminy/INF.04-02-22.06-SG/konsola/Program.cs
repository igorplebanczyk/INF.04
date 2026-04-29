Console.WriteLine("Liczba zarejestrowanych osób to " + Osoba.instancje);

Osoba osoba1 = new Osoba();

Console.WriteLine("Wprowadź imię: ");
string imie = Console.ReadLine();

Console.WriteLine("Wprowadź id: ");
int id = int.Parse(Console.ReadLine());

Osoba osoba2 = new Osoba(id, imie);
Osoba osoba3 = new Osoba(osoba2);

osoba1.wypiszImie("Jan");
osoba2.wypiszImie("Jan");
osoba3.wypiszImie("Jan");

Console.WriteLine("Liczba zarejestrowanych osób to " + Osoba.instancje);

class Osoba
{
    private int id;
    private string imie;
    public static int instancje = 0;

    public Osoba()
    {
        this.id = 0;
        this.imie = "";
        instancje++;
    }

    public Osoba(int id, string imie)
    {
        this.id = id;
        this.imie = imie;
        instancje++;
    }

    public Osoba(Osoba osoba)
    {
        this.id = osoba.id;
        this.imie = osoba.imie;
        instancje++;
    }

    public void wypiszImie(string drugieImie)
    {
        if (this.imie != "") Console.WriteLine("Cześć " + drugieImie + " mam na imię " + this.imie);
        else Console.WriteLine("Brak danych");
    }
}