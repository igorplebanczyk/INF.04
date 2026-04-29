Console.WriteLine("Wprowadź liczbę całkowitą a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Wprowadź liczbę całkowitą b: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Największy wspólny dzielnik liczb a i b wynosi " + nwd(a, b));

/**********************************************
nazwa funkcji: nwd
opis funkcji: oblicza największy wspólny dzielnik dwóch liczb całkowitych
parametry: a - pierwsza z pary liczb, dla której obliczane będzie nwd
b - drugie z pary liczb, dla której obliczane będzie nwd
zwracany typ i opis: int - zwracany jest największy wspólny dzielnik liczb a i b
autor: 123456789012
***********************************************/
int nwd(int a, int b)
{
    while (a != b)
    {
        if (a > b) a -= b;
        else b -= a;
    }

    return a;
}