using System.IO;
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

namespace _2024_czerwiec_02_desktopowa
{
    public partial class MainWindow : Window
    {
        Album[] albums;
        int currentAlbumIndex = 0;

        public MainWindow()
        {
            InitializeComponent();

            string[] data = File.ReadAllLines("Data.txt");
            Album[] albums = new Album[(data.Length / 6) + 1]; // Ostatnia linijka w Data.txt jest pusta, nie jest brana pod uwagę, więc Data.Length jest równe 83, co powoduje że Data.Length / 6 jest zaniżane w dół do 13, zamiast potrzebnych 14

            for (int i = 0; i < data.Length; i += 6)
            {
                Album album = new Album(
                    data[i],
                    data[i + 1],
                    int.Parse(data[i + 2]),
                    int.Parse(data[i + 3]),
                    int.Parse(data[i + 4])
                );

                albums[i / 6] = album;
            }

            this.albums = albums;

            changeCurrentAlbumText(0);
        }

        private void SwitchLeft(object sender, RoutedEventArgs e)
        {
            if (currentAlbumIndex == 0) currentAlbumIndex = albums.Length - 1;
            else currentAlbumIndex--;

            changeCurrentAlbumText(currentAlbumIndex);
        }

        private void SwitchRight(object sender, RoutedEventArgs e)
        {
            if (currentAlbumIndex == albums.Length - 1) currentAlbumIndex = 0;
            else currentAlbumIndex++;

            changeCurrentAlbumText(currentAlbumIndex);
        }

        private void Download(object sender, RoutedEventArgs e)
        {
            albums[currentAlbumIndex].downloadNumber++;

            changeCurrentAlbumText(currentAlbumIndex);
        }

        private void changeCurrentAlbumText(int index)
        {
            labelArtist.Content = albums[index].artist;
            labelAlbum.Content = albums[index].album;
            labelSongsNumber.Content = albums[index].songsNumber + " utworów";
            labelYear.Content = albums[index].year;
            labelDownloadNumber.Content = albums[index].downloadNumber;
        }
    }
    class Album
    {
        public string artist;
        public string album;
        public int songsNumber;
        public int year;
        public int downloadNumber;

        public Album(string artist, string album, int songsNumber, int year, int downloadNumber)
        {
            this.artist = artist;
            this.album = album;
            this.songsNumber = songsNumber;
            this.year = year;
            this.downloadNumber = downloadNumber;
        }
    }
}