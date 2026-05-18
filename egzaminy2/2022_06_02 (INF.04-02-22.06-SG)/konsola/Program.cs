namespace _2022_06_02_k
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Liczba zarejestrowanych osób to " + Osoba.liczbaInstancji);

            Osoba osoba1 = new();

            Console.WriteLine("Podaj id: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj imię: ");
            string imie = Console.ReadLine();
            
            Osoba osoba2 = new(id, imie);
            Osoba osoba3 = new(osoba2);

            osoba1.Powitaj("Jan");
            osoba2.Powitaj("Jan");
            osoba3.Powitaj("Jan");

            Console.WriteLine("Liczba zarejestrowanych osób to " + Osoba.liczbaInstancji);
        }
    }
}