using System.Windows;

namespace _2023_styczen_01_desktopowa
{
    public partial class MainWindow : Window
    {
        string password;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GeneratePasswordButtonClick(object sender, RoutedEventArgs e)
        {
            if (charactersCountTextBox == null || uppercaseLettersCheckbox == null || integersCheckbox == null || specialCharactersCheckbox == null) return;

            int charactersCount = int.Parse(charactersCountTextBox.Text);
            bool useUppercaseLetters = (bool)uppercaseLettersCheckbox.IsChecked;
            bool useIntegers = (bool)integersCheckbox.IsChecked;
            bool useSpecialCharacters = (bool)specialCharactersCheckbox.IsChecked;

            const string lowercaseLetters = "aąbcćdeęfghijklmnńoópqrsśtuvwxyzźż";
            const string uppercaseLetters = "AĄBCĆDEĘFGHIJKLMNŃOÓPQRSŚTUVWXYZ";
            const string specialCharacters = "!@#$%^&*()_+-=";

            string password = "";
            Random random = new();

            if (useUppercaseLetters)
            {
                password += uppercaseLetters[random.Next(0, uppercaseLetters.Length)];
                charactersCount--;
            }

            if (useIntegers)
            {
                password += random.Next(0, 10).ToString();
                charactersCount--;
            }

            if (useSpecialCharacters)
            {
                password += specialCharacters[random.Next(0, specialCharacters.Length)];
                charactersCount--;
            }

            for (int i = 0; i < charactersCount; i++)
            {
                password += lowercaseLetters[random.Next(0, lowercaseLetters.Length)];
            }

            this.password = password;
            MessageBox.Show(this.password);
        }

        private void ConfirmButtonClick(object sender, RoutedEventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string position = positionComboBox.SelectionBoxItem.ToString();

            MessageBox.Show("Dane pracownika " + firstName + " " + lastName + " " + position + " Hasło: " + this.password);
        }
    }
}