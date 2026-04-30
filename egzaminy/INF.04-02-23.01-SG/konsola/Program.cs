Notatka notatka1 = new Notatka("Testowa notatka nr 1", "Treść testowej notatki nr 1");
notatka1.wyswietlTytulITresc();
notatka1.wyswietlWszystkiePola();

Notatka notatka2 = new Notatka("Testowa notatka nr 2", "Treść testowej notatki nr 2");
notatka2.wyswietlTytulITresc();
notatka2.wyswietlWszystkiePola();

/************************************************
klasa: Notatka
opis: klasa reprezentuję prostą notatkę
pola: licznik - ilość utworzonych dotychczas instancji klasy
id - unikalny identyfikator klasy
tytul - tytuł notatki
tresc - treść notatki
autor: 12345678901
************************************************/
class Notatka
{
    private static int licznik;
    private int id;
    protected string tytul;
    protected string tresc;

    public Notatka(string tytul, string tresc)
    {
        licznik++;
        this.id = licznik;
        this.tytul = tytul;
        this.tresc = tresc;
    }

    public void wyswietlTytulITresc()
    {
        Console.WriteLine("Tytuł notatki: " + this.tytul);
        Console.WriteLine("Tresc notatki: " + this.tresc);
    }

    public void wyswietlWszystkiePola()
    {
        Console.WriteLine("Wartości pól licznik, id, tytul, tresc: " + licznik + ", " + this.id + ", " + this.tytul + ", " + this.tresc);
    }
}