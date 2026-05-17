class Program
{
    static void FillArray(int[] array)
    {
        Random random = new();
        for (int i = 0; i < array.Length; i++) array[i] = random.Next(1, 101);
    }

    /******************************************************
    nazwa funkcji: SearchWithSentinel
    argumenty: array - tablica do przeszukania
    value - wartość do znalezienia
    typ zwracany: int, indeks pod którym znaleziono wartość
    informacje: metoda realizuje algorytm szukania z wartownikiem
    autor: 01234567890
    *****************************************************/
    static int SearchWithSentinel(int[] array, int value)
    {
        int[] sentinelArray = new int[array.Length + 1];

        for (int i = 0; i < array.Length; i++) sentinelArray[i] = array[i];
        sentinelArray[array.Length] = value;

        for (int i = 0; i < sentinelArray.Length; i++)
        {
            if (sentinelArray[i] == value) return i;
        }

        return array.Length;
    }

    static void Main()
    {
        Console.Write("Podaj liczbę do znalezienia: ");
        int value = int.Parse(Console.ReadLine());

        int[] array = new int[50];
        FillArray(array);

        int valueIndex = SearchWithSentinel(array, value);

        Console.WriteLine();
        Console.Write("Elementy tablicy: ");
        for (int i = 0; i < array.Length; i++)
        {
            if (i != array.Length - 1) Console.Write(array[i] + ", ");
            else Console.Write(array[i]);
        }

        Console.WriteLine();
        if (valueIndex != array.Length) Console.WriteLine("Znaleziono wartość " + value + " pod indeksem " + valueIndex);
        else Console.WriteLine("Nie znaleziono wartości " + value);
    }
}