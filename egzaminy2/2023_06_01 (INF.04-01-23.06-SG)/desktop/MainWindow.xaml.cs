using System.Windows;
using System.Windows.Media.Imaging;

namespace _2023_06_01_d
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckPrice(object sender, RoutedEventArgs e)
        {
            if (radioButtonPostcard.IsChecked == true)
            {
                imagePackageType.Source = new BitmapImage(new Uri("/images/pocztowka.png", UriKind.Relative));
                labelPrice.Content = "Cena: 1zł";
            }

            if (radioButtonLetter.IsChecked == true)
            {
                imagePackageType.Source = new BitmapImage(new Uri("/images/list.png", UriKind.Relative));
                labelPrice.Content = "Cena: 1,5zł";
            }

            if (radioButtonPackage.IsChecked == true)
            {
                imagePackageType.Source = new BitmapImage(new Uri("/images/paczka.png", UriKind.Relative));
                labelPrice.Content = "Cena: 10zł";
            }
        }

        private void Confirm(object sender, RoutedEventArgs e)
        {
            if (textBoxPostalCode.Text.Length != 5)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
                return;
            }

            if (!int.TryParse(textBoxPostalCode.Text, out _))
            {
                MessageBox.Show("Kod pocztowy powinien się składać się z samych cyfr");
                return;
            }

            MessageBox.Show("Dane przesyłki zostały wprowadzone");
        }
    }
}