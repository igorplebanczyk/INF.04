namespace _2025_czerwiec_02_konsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst:");
            string text = Console.ReadLine();

            Console.WriteLine("Podaj klucz:");
            int key = int.Parse(Console.ReadLine());

            string result = Caesar.CaesarCipher(text, key);

            Console.WriteLine("Wynik:");
            Console.WriteLine(result);
        }
    }
}