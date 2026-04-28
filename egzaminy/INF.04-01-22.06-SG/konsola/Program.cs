int[] generateArray(int length)
{
    Random random = new();
    int[] array = new int[length + 1];

    for (int i = 0; i < length; i++) array[i] = random.Next(1, 101);

    return array;
}

/******************************************************
nazwa funkcji: findValueInArray
argumenty: array - tablicę, która będzie przechowywana
value - wartość, którą należy znaleźć
typ zwracany: int, indeks znalezionej wartości, lub -1 gdy wartość nie została znaleziona
informacje: algorytm przeszukiwania z wartownikiem; funkcja szuka danej wartości w tablicy, jeśli jej tam nie ma, napotyka wartownika co świadczy o braku szukanej wartości w tablicy
autor: 123456789012
*****************************************************/
int findValueInArray(int[] array, int value)
{
    array[array.Length - 1] = value;

    int i = 0;
    while (array[i] != value) i++;

    if (i == array.Length - 1) return -1;
    else return i;
}

Console.WriteLine("Podaj wartość do znalezienia: ");
int value = int.Parse(Console.ReadLine());

int[] array = generateArray(50);    
int foundValueIndex = findValueInArray(array, value);

for (int i = 0; i < array.Length - 1; i++)
{
    if (i == array.Length - 2) Console.WriteLine(array[i]);
    else Console.Write(array[i] + ", ");
}
if (foundValueIndex == -1) Console.WriteLine("Nie znaleziono wartości w tablicy.");
else Console.WriteLine("Znaleziono wartość " + value + " pod indeksem " + foundValueIndex + " .");