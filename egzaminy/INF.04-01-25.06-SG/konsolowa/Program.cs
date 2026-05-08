int[][] generateSetsOfDraws(int[][] drawSets)
{
    Random random = new();

    for (int i = 0; i < drawSets.Length; i++)
    {
        drawSets[i] = new int[6];
        List<int> drawn = new();

        for (int j = 0; j < 6; j++)
        {
            bool success = false;
            while (!success)
            {
                int draw = random.Next(1, 50);
                if (!drawn.Contains(draw))
                {
                    success = true;
                    drawSets[i][j] = draw;
                    drawn.Add(draw);
                }
            }
        }
    }

    return drawSets;
}

/**********************************************
nazwa funkcji: displaySetsOfDraws
opis funkcji: wyświetla zestawy losowań i liczbę wystąpień poszczególnych liczb
parametry: drawSets - zestawy losowań do wyświetlenia
zwracany typ i opis: brak
autor: 12345678901
***********************************************/
void displaySetsOfDraws(int[][] drawSets)
{
    Console.WriteLine("Zestawy wylosowanych liczb:");

    Dictionary<int, int> occurences = new();

    for (int i = 0; i < drawSets.Length; i++)
    {
        Console.Write("Losowanie " + (i + 1) + ": ");

        foreach (int draw in drawSets[i])
        {
            Console.Write(draw + " ");

            if (occurences.ContainsKey(draw)) occurences[draw]++;
            else occurences.Add(draw, 1);
        }

        Console.WriteLine();
    }

    foreach (var kvp in occurences.OrderBy(kvp => kvp.Key)) Console.WriteLine("Wystąpienia liczby " + kvp.Key + ": " + kvp.Value);
}

Console.WriteLine("Ile wygenerować losowań?");
int numberOfSets = int.Parse(Console.ReadLine());

int[][] drawSets = new int[numberOfSets][];

drawSets = generateSetsOfDraws(drawSets);
displaySetsOfDraws(drawSets);
