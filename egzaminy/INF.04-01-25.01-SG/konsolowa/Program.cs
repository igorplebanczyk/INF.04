ArrayUtilities arrayUtils = new(25);
arrayUtils.displayArrayElements();

int foundValueIndex = arrayUtils.findInArray(89);
if (foundValueIndex != -1) Console.WriteLine("Znaleziono wartość 89 pod indeksem " + foundValueIndex);

int oddNumbersCount = arrayUtils.displayOddNumbersAndGetTheirCount();
Console.WriteLine("Razem liczb nieparzystych: " + oddNumbersCount);

int average = arrayUtils.getAverageValue();
Console.WriteLine("Średnia wszystkich elementów: " + average);


class ArrayUtilities
{
    private int[] array;
    private int arrayLength;

    public ArrayUtilities(int arrayLength)
    {
        this.arrayLength = arrayLength;

        array = new int[arrayLength];

        Random random = new();
        for (int i = 0; i < arrayLength; i++) array[i] = random.Next(1, 1001);
    }

    /**********************************************
    nazwa metody: displayArrayElements
    opis metody: wyświetla w konsoli wszystkie elementy tablicy wraz z ich indeksami
    parametry: brak
    zwracany typ i opis: brak
    autor: 12345678901
    ***********************************************/
    public void displayArrayElements()
    {
        Console.WriteLine("Elementy tablicy:");
        for (int i = 0; i < arrayLength; i++) Console.WriteLine(i + ": " + array[i]);
    }

    public int findInArray(int value)
    {
        for (int i = 0; i < arrayLength; i++) if (array[i] == value) return i;
        return -1;
    } 

    public int displayOddNumbersAndGetTheirCount()
    {
        int count = 0;
        Console.WriteLine("Liczby nieparzyste:");

        foreach(int elem in array)
        {
            if (elem % 2 != 0)
            {
                count++;
                Console.WriteLine(elem);
            }
        }

        return count;
    }

    public int getAverageValue()
    {
        int sum = 0;
        foreach (int elem in array) sum += elem;

        return sum / arrayLength;
    }
}