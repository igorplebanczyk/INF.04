using System.Windows;

namespace _2023_01_01_d
{
    public partial class MainWindow : Window
    {
        string password = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GeneratePassword(object sender, RoutedEventArgs e)
        {
            string lowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
            string uppercaseLetters = lowercaseLetters.ToUpper();
            string integers = "0123456789";
            string specialCharacters = "@#$%^&*()_+-=";

            string characterSet = lowercaseLetters;
            string password = "";
            int charactersCount = int.Parse(textBoxCharactersCount.Text);

            Random random = new();

            if (checkBoxUppercaseLetters.IsChecked == true) characterSet += uppercaseLetters;
            if (checkBoxIntegers.IsChecked == true) characterSet += integers;
            if (checkBoxSpecialCharacters.IsChecked == true) characterSet += specialCharacters;

            for (int i = 0; i < charactersCount; i++) password += characterSet[random.Next(0, characterSet.Length)];

            this.password = password;
            MessageBox.Show(password);
        }

        private void Confirm(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Dane pracownika: " + textBoxName.Text + " " + textBoxLastName.Text + " " + comboBoxPosition.Text + " Hasło: " + password);
        }
    }
}