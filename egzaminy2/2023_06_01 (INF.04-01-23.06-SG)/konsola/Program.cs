class Program
{
    static void Main()
    {
        bool[] array = new bool[101];
        FillArray(array);
        FindPrimes(array);

        Console.Write("Liczby pierwsze: ");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == true) Console.Write(i + " ");
        }
    }

    /*******************************************************
    nazwa funkcji: FillArray
    parametry wejściowe: array - tablicę do wypełnienia
    wartość zwracana: brak
    informacje: funkcja wypełnia daną tablicę typu bool wartościami true, zaczynając od drugiego indeksu
    autor: 01234567890
    ****************************************************/
    static void FillArray(bool[] array)
    {
        for (int i = 2; i < array.Length; i++) array[i] = true;
    }

    static void FindPrimes(bool[] array)
    {
        for (int i = 2; i <= Math.Sqrt(array.Length - 1); i++)
        {
            if (array[i] == true)
            {
                for (int j = 2 * i; j <= array.Length - 1; j += i)
                {
                    array[j] = false;
                }
            }
        }
    }
}