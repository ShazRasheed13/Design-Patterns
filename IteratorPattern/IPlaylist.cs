using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    // Aggregate interface
    public interface IPlaylist
    {
        IIterator GetIterator();
    }

    public class Playlist : IPlaylist
    {
        private readonly string[] _songs;

        public Playlist(string[] songs)
        {
            _songs = songs;
        }

        public IIterator GetIterator()
        {
            return new PlaylistIterator(_songs);
        }
    }
}
