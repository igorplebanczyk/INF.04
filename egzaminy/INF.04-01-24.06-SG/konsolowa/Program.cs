/***********************************************
nazwa: throwDices
opis: wykonuje "rzuty kostką" - losuje liczby z zakresu 1-6 tyle razy, ile wskazuje argument throws
parametry: throws - oznacza ile rzutów kostką należy wykonać
zwracany typ i opis: int[] - tablica z wynikami rzutów kostką
autor: 12345678901
************************************************/
int[] throwDices(int throws) {
    Random random = new();
    int[] results = new int[throws];
    
    for (int i = 0; i < throws; i++) results[i] = random.Next(1, 7);

    return results;
}

int countPoints(int[] results)
{
    Dictionary<int, int> counts = new();

    foreach (int result in results)
    {
        if (counts.ContainsKey(result))
            counts[result]++;
        else
            counts[result] = 1;
    }

    int points = 0;

    foreach (var kvp in counts)
    {
        int dots = kvp.Key;      
        int throwsCount = kvp.Value;

        if (throwsCount >=2) points += dots * throwsCount;
    }

    return points;
}

while (true) {
    int throws = 0;
    while (throws < 3 || throws > 10)
    {
        Console.WriteLine("Ile kostek chcesz rzucić (3 - 10)?");
        throws = int.Parse(Console.ReadLine());
    }

    int[] results = throwDices(throws);
    for (int i = 0; i < results.Length; i++) Console.WriteLine("Kostka " + i + ": " + results[i]);

    Console.WriteLine("Liczba uzyskanych punktów: " + countPoints(results));

    Console.WriteLine("Jeszcze raz? (t/n)");
    char answer = char.Parse(Console.ReadLine());
    if (answer == 'n') break;
}