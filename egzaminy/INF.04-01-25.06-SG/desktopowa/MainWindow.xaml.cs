using System.Windows;
using System.Windows.Media;

namespace _2025_czerwiec_01_desktopowa
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sliderR == null || sliderG == null || sliderB == null) return;

            rectangleColor.Fill = new SolidColorBrush(getCurrentColor());
        }

        private void Download(object sender, RoutedEventArgs e)
        {
            Color color = getCurrentColor();
            labelColor.Background = new SolidColorBrush(color);

            labelColor.Content = color.R + ", " + color.G + ", " + color.B;
        }

        private Color getCurrentColor()
        {
            return Color.FromRgb(
                (byte)sliderR.Value,
                (byte)sliderG.Value,
                (byte)sliderB.Value
            );
        }
    }
}