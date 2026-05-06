Album[] loadAlbums()
{
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

    return albums;
}

/**********************************************
nazwa funkcji: displayAlbums
opis funkcji: wyświetla w konsoli wszystkie albumy z danej listy albumów
parametry: albums - lista albumów do wyświetlenia, w postaci tablicy instancji klasy Album
zwracany typ i opis: brak
autor: 12345678901  
***********************************************/
void displayAlbums(Album[] albums)
{
    foreach (Album album in albums)
    {
        Console.WriteLine(album.artist);
        Console.WriteLine(album.album);
        Console.WriteLine(album.songsNumber);
        Console.WriteLine(album.year);
        Console.WriteLine(album.downloadNumber);
        Console.WriteLine("");
    }
}

Album[] albums = loadAlbums();
displayAlbums(albums);

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