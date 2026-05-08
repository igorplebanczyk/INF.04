namespace _2025_czerwiec_02_konsola
{
    public static class Caesar
    {
        public static string CaesarCipher(string text, int key)
        {
            string ciphered = "";
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            if (key > alphabet.Length) key = key - alphabet.Length;

            foreach (char c in text)
            {
                if (!alphabet.Contains(c))
                {
                    ciphered += c;
                    continue;
                }

                int currentIndex = alphabet.IndexOf(c);
                int newIndex;

                if (currentIndex + key > alphabet.Length - 1) newIndex = currentIndex + key - alphabet.Length;
                else if (currentIndex + key < 0) newIndex = alphabet.Length + key;
                else newIndex = currentIndex + key;

                ciphered += alphabet[newIndex];
            }

            return ciphered;
        }
    }
}
