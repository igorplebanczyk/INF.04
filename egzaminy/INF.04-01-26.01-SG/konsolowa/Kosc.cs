namespace _2026_styczen_01_konsola
{
    public class Kosc
    {
        public static int liczbaInstancji;

        public string[] obrazy = ["kosc0.png", "kosc1.png", "kosc2.png", "kosc3.png", "kosc4.png", "kosc5.png", "kosc6.png"];
        public int liczbaOczek;
        public int indeksObrazu;
        public bool czyDostepna;

        public Kosc(int liczbaOczek)
        {
            if (liczbaOczek < 1 || liczbaOczek > 6) {
                this.liczbaOczek = 0;
                indeksObrazu = 0;
            }
            else {
                this.liczbaOczek = liczbaOczek;
                indeksObrazu = liczbaOczek;
            }

            czyDostepna = true;
            liczbaInstancji++;
        }

        public Kosc()
        {
            Random random = new();
            int liczbaOczek = random.Next(1, 7);

            this.liczbaOczek = liczbaOczek;
            indeksObrazu = liczbaOczek;
            czyDostepna = true;
            liczbaInstancji++;
        }

        public void RzucKoscia()
        {
            if (!czyDostepna) return;

            Random random = new();
            int liczbaOczek = random.Next(1, 7);

            this.liczbaOczek = liczbaOczek;
            indeksObrazu = liczbaOczek;
        }

        public void ZablokujKosc()
        {
            czyDostepna = false;
        }

        public string PodajLiczbeOczek()
        {
            switch (liczbaOczek)
            {
                case 1: return "jeden";
                case 2: return "dwa";
                case 3: return "trzy";
                case 4: return "cztery";
                case 5: return "pięć";
                case 6: return "sześć";
            }

            return "";
        }
    }
}
