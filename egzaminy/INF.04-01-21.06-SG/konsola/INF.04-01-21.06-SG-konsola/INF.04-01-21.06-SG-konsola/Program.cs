SelectionSort sort = new SelectionSort();

Console.WriteLine("");

sort.Sort();
foreach (int item in sort.array)
{
    Console.WriteLine(item);
}

class SelectionSort
{
    public int[] array;

    public SelectionSort()
    {
        array = new int[10];

        Console.WriteLine("Wprowadź 10 liczb całkowitych w kolejnych liniach: ");
        for (int i = 0; i < array.Length; i++) array[i] = int.Parse(Console.ReadLine().ToString());
    }

    /********************************************************
    * nazwa funkcji: Sort
    * parametry wejściowe: brak
    * wartość zwracana: brak
    * autor: 123456789012
    * ****************************************************/
    public void Sort()
    {
        for (int i = 0; i < array.Length; i++)
        {
            int maxValueIndex = GetMaxValueIndex(i);

            int temp = array[i];
            array[i] = array[maxValueIndex];
            array[maxValueIndex] = temp;
        }
    }

    /********************************************************
    * nazwa funkcji: GetMaxValueIndex
    * parametry wejściowe: startIndex - int
    * wartość zwracana: int - indeks elementu zawierającego miminalną wartość tablicy array (pola klasy SelectionSort)
    * autor: 123456789012
    * ****************************************************/
    private int GetMaxValueIndex(int startIndex)
    {
        int currentMax = int.MinValue;
        int currentMaxIndex = -1;

        for (int i = startIndex; i < array.Length; i++)
        {
            if (array[i] > currentMax)
            {
                currentMax = array[i];
                currentMaxIndex = i;
            }
        }

        return currentMaxIndex;
    }
}