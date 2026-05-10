namespace _2026_styczen_01_konsola
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Podaj liczbę oczek na kości: ");
            int liczbaOczek = int.Parse(Console.ReadLine());

            Kosc kosc1 = new(liczbaOczek);
            Console.WriteLine("Liczba instancji klasy Kosc: " + Kosc.liczbaInstancji);
            Console.WriteLine("Kością wyrzucono " + kosc1.liczbaOczek + " (" + kosc1.PodajLiczbeOczek() + ")");
            Console.WriteLine("Tej liczbie oczek odpowiada plik " + kosc1.obrazy[kosc1.indeksObrazu]);

            Console.WriteLine();

            Kosc kosc2 = new();
            Console.WriteLine("Liczba instancji klasy Kosc: " + Kosc.liczbaInstancji);
            Console.WriteLine("Kością wyrzucono " + kosc2.liczbaOczek + " (" + kosc2.PodajLiczbeOczek() + ")");
            Console.WriteLine("Tej liczbie oczek odpowiada plik " + kosc2.obrazy[kosc2.indeksObrazu]);
        }
    }
}
