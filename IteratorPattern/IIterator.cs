using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    // Iterator interface
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }

    public class PlaylistIterator : IIterator
    {
        private readonly string[] _songs;
        private int _currentPosition=0;

        public PlaylistIterator(string[] songs)
        {
            _songs = songs;
        }
        public bool HasNext()
        {
            return _currentPosition < _songs.Length;
        }

        public object Next()
        {
            if (HasNext())
            {
                return _songs[_currentPosition++];
            }
            else
            {
                return null;
            }
        }
    }


}
