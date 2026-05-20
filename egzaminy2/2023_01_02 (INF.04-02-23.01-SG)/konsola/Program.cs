namespace _2023_01_02_k
{
    class Program
    {
        static void Main()
        {
            Notatka notatka1 = new("Lista zakupów", "Ziemniaki, mleko, jajka");
            notatka1.wyswietlTytulITresc();
            notatka1.wyswietlWszystkieWartosci();

            Notatka notatka2 = new("Do zrobienia", "Posprzątać, odkurzyć");
            notatka2.wyswietlTytulITresc();
            notatka2.wyswietlWszystkieWartosci();
        }
    }
}