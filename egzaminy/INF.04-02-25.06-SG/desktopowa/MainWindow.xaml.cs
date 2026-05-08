using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace _2025_czerwiec_02_desktopowa
{
    public partial class MainWindow : Window
    {
        private string encrypted;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Encrypt(object sender, RoutedEventArgs e)
        {
            int key;
            if (!int.TryParse(textBoxKey.Text, out key)) key = 0;

            encrypted = CaesarCipher(textBoxText.Text, key);
            textBlockEncrypted.Text = encrypted;
        }

        private void SaveToFile(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new();
            dialog.ShowDialog();

            File.AppendAllText(dialog.FileName, encrypted);
        }
        private string CaesarCipher(string text, int key)
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