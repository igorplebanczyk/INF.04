/*******************************************************
nazwa funkcji: wypelnijTablice
parametry wejściowe: tablica - tablice do wypelnienia
wartość zwracana: brak
informacje: funkcja wypelnia tablice typu logicznego wartościami true
autor: 12345678901
****************************************************/
void wypelnijTablice(bool[] tablica)
{
    for (int i = 2; i < tablica.Length; i++)
    {
        tablica[i] = true;
    }
}

List<int> sitoErastotenesa(bool[] tablica)
{
    List<int> indeksyWartosciTrue = [];

    for (int i = 2; i <= Math.Sqrt(tablica.Length - 1); i++)
    {
        if (tablica[i])
        {
            for (int j = 2 * i; j < tablica.Length; j += i)
            {
                tablica[j] = false;
            }
        }
    }

    for (int i = 2; i < tablica.Length; i++)
    {
        if (tablica[i])
        {
            indeksyWartosciTrue.Add(i);
        }
    }

    return indeksyWartosciTrue;
}

bool[] tablica = new bool[101];
wypelnijTablice(tablica);

List<int> liczbyPierwsze = sitoErastotenesa(tablica);

Console.WriteLine("Liczby pierwsze w przedziale 2 do 100: ");
foreach (int num in liczbyPierwsze) Console.Write(num + " ");