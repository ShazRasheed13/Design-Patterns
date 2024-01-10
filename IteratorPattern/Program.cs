using IteratorPattern;

string[] songs = { "Song A", "Song B", "Song C", "Song D" };
IPlaylist playlist = new Playlist(songs);
IIterator iterator = playlist.GetIterator();

Console.WriteLine("Playlist Songs:");

while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next());
}
