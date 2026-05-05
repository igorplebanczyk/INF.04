using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace _2024_styczen_01_desktopowa
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            string number = TextBoxNumber.Text;

            ImageFingerprint.Source = new BitmapImage(new Uri("/images/" + number + "-odcisk.jpg", UriKind.Relative));
            ImagePerson.Source = new BitmapImage(new Uri("/images/" + number + "-zdjecie.jpg", UriKind.Relative));
        }

        private void OkButtonClick(object sender, RoutedEventArgs e)
        {
            if (TextBoxName.Text == "" || TextBoxLastName.Text == "")
            {
                MessageBox.Show("Wprowadź dane");
                return;
            }

            string eyeColor = "";

            if (RadioButtonBlue.IsChecked == true) eyeColor = "niebieskie";
            if (RadioButtonGreen.IsChecked == true) eyeColor = "zielone";
            if (RadioButtonBrown.IsChecked == true) eyeColor = "piwne";


            MessageBox.Show(TextBoxName.Text + " " + TextBoxLastName.Text + " kolor oczu " + eyeColor);
        }
    }
}