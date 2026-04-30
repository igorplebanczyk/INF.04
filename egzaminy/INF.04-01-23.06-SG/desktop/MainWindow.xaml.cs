using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2023_czerwiec_01_desktopowa
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void CheckPriceButton(object sender, RoutedEventArgs e)
        {
            if (RadioButtonPostcard.IsChecked == true)
            {
                LabelPrice.Content = "Cena: 1 zł";
                ImageType.Source = new BitmapImage(new Uri("/images/pocztowka.png", UriKind.Relative));
            }

            if (RadioButtonLetter.IsChecked == true)
            {
                LabelPrice.Content = "Cena: 1,5 zł";
                ImageType.Source = new BitmapImage(new Uri("/images/list.png", UriKind.Relative));
            }

            if (RadioButtonPackage.IsChecked == true)
            {
                LabelPrice.Content = "Cena: 10 zł";
                ImageType.Source = new BitmapImage(new Uri("/images/paczka.png", UriKind.Relative));
            }
        }

        public void ConfirmButtonClick(object sender, RoutedEventArgs e)
        {
            if (TextBoxPostalCode.Text.Length != 5)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
                return;
            }

            if (!int.TryParse(TextBoxPostalCode.Text, out int postalCode))
            {
                MessageBox.Show("Kod pocztowy powinien składać się z samych cyfr");
                return;
            }

            MessageBox.Show("Dane przesyłki zostały wprowadzone");
        }
    }
}