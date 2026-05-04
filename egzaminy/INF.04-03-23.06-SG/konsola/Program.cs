film film = new();
Console.WriteLine("Tytuł filmu: " + film.otrzymajTytul());
Console.WriteLine("Liczba wypożyczeń filmu: " + film.otrzymajLiczbeWypozyczen());

film.ustawTytul("Miś Gogo");
Console.WriteLine("Nowy tytuł filmu: " + film.otrzymajTytul());

film.zinkrementulLiczbeWypozyczen();
Console.WriteLine("Nowa liczba wypożyczeń: " + film.otrzymajLiczbeWypozyczen());

/*****************************************************
nazwa klasy: film
pola: tytul - tytuł filmu
liczbaWypozyczen - liczba wypożyczeń filmu
metody: ustawTytul, nic – ustawia tytuł na podaną wartość
otrzymajTytul, string - zwraca tytuł filmu
zinkrementujLiczbeWypozyczen, nic - inkrementuje liczbę wypożyczeń
otrzymajLiczbeWypozyczen, int - zwraca liczbę wypożyczeń
informacje: klasa reprezentuje film - przechowuje jego tytuł oraz liczbę wypożyczeń i pozwala na modyfikację tych wartości
autor: 012345678901
*****************************************************/
class film
{
    protected string tytul;
    protected int liczbaWypozyczen;

    public film()
    {
        tytul = "";
        liczbaWypozyczen = 0;
    }

    public void ustawTytul(string tytul)
    {
        this.tytul = tytul;
    }

    public string otrzymajTytul()
    {
        return tytul;
    }

    public void zinkrementulLiczbeWypozyczen()
    {
        liczbaWypozyczen++;
    }

    public int otrzymajLiczbeWypozyczen()
    {
        return liczbaWypozyczen;
    }
}