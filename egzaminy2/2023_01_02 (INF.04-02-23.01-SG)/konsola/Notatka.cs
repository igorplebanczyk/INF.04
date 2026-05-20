namespace _2023_01_02_k
{
    /************************************************
    klasa: Notatka
    opis: klasa reprezentuję notatkę
    pola: liczbaNotatek - przechowuje liczbę wszystkich notatek
          id - przechowuje identyfikator notatki
          tytul - przechowuje tytuł notatki
          tresc - przechowuje treść notatki
    autor: 01234567890
    ************************************************/
    internal class Notatka
    {
        private static int liczbaNotatek;
        private int id;
        protected string tytul;
        protected string tresc;

        public Notatka(string tytul, string tresc)
        {
            liczbaNotatek++;
            id = liczbaNotatek;
            this.tytul = tytul;
            this.tresc = tresc;
        }

        public void wyswietlTytulITresc()
        {
            Console.WriteLine("Tytuł: " + tytul);
            Console.WriteLine("Treść: " + tresc);
        }

        public void wyswietlWszystkieWartosci()
        {
            Console.WriteLine("Liczba notatek: " + liczbaNotatek + ", Identyfikator: " + id + ", Tytuł: " + tytul + ", Treść: " + tresc);
        }
    }
}
