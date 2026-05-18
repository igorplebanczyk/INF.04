namespace _2022_06_02_k
{
    internal class Osoba
    {
        public static int liczbaInstancji = 0;
        
        private int id;
        private string imie;

        public Osoba()
        {
            id = 0;
            imie = "";
            liczbaInstancji++;
        }

        public Osoba(int id, string imie)
        {
            this.id = id;
            this.imie = imie;
            liczbaInstancji++;
        }

        public Osoba(Osoba osoba)
        {
            id = osoba.id;
            imie = osoba.imie;
            liczbaInstancji++;
        }

        public void Powitaj(string imie)
        {
            if (this.imie == "") Console.WriteLine("Brak danych");
            else Console.WriteLine("Cześć " + imie + ", mam na imię " + this.imie);
        }
    }
}
