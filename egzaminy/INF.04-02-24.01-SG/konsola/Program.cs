Console.WriteLine("Podaj tekst: ");
string text = Console.ReadLine();

Console.WriteLine("Liczba samogłosek: " + StringUtilities.countVowels(text));
Console.WriteLine("Tekst po eliminacji duplikatów: " + StringUtilities.removeRepeatingCharacters(text));

/************************************************
klasa: StringUtilities
opis: Klasa grupuje ze sobą metody wykonujące operacje na typie string
metody: countVowels - zwraca liczbę samogłosek w podanym tekście
removeRepeatingCharacters - zwraca tekst bez powtarzających się sąsiadujących znaków
autor: 12345678901
************************************************/
static class StringUtilities
{
    public static int countVowels(string str)
    {
        string vowels = "aąeęiouóyAĄEĘIOUÓY";
        int count = 0;

        foreach (char character in str)
        {
            foreach(char vowel in vowels)
            {
                if (character == vowel) count++;
            }
        }

        return count;
    }

    public static string removeRepeatingCharacters(string str)
    {
        if (str == "" || str == null) return "";

        string updated = "";

        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] != str[i + 1])
            {
                updated += str[i];
            }
        }

        updated += str[str.Length - 1];

        return updated;
    }
}