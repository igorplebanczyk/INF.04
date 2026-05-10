using _2026_styczen_01_konsola;

namespace _2026_styczen_01_testy
{
    [TestClass]
    public sealed class KoscTesty
    {
        [TestMethod]
        public void CzyWyrzuconaWartoscJestWZakresie1do6()
        {
            Kosc kosc = new();

            Assert.IsInRange(1, 6, kosc.liczbaOczek);
        }

        [TestMethod]
        public void CzyWartoscKosciJestNiezmiennaGdyKoscJestNiedostepna()
        {
            Kosc kosc = new();
            int wartoscKosciPrzedZablokowaniem = kosc.liczbaOczek;
            kosc.ZablokujKosc();
            kosc.RzucKoscia();
            int wartoscKosciPoZablokowaniu = kosc.liczbaOczek;

            Assert.AreEqual(wartoscKosciPrzedZablokowaniem, wartoscKosciPoZablokowaniu);
        }
    }
}
