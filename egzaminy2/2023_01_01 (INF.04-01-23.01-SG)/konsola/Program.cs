class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj pierwszą liczbę:");
        uint a = uint.Parse(Console.ReadLine());

        Console.WriteLine("Podaj drugą liczbę:");
        uint b = uint.Parse(Console.ReadLine());

        Console.WriteLine("NWD liczb " + a + " i " + b + " wynosi " + Nwd(a, b));
    }

    /**********************************************
    nazwa funkcji: Nwd
    opis funkcji: oblicza NWD dwóch podanych liczb
    parametry: a - pierwsza liczba z pary, dla której będzie obliczane NWD
    b - druga liczba z pary, dla której będzie obliczane NWD
    zwracany typ i opis: uint - NWD dwóch podanych liczb
    autor: 01234567890
    ***********************************************/
    static uint Nwd(uint a, uint b) 
    { 
        while (a != b)
        {
            if (a > b) a -= b;
            else b -= a;
        }

        return a;
    }
}