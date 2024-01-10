using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public interface Image
    {
        void Display();
    }

    public class RealImage : Image
    {
        private string fileName;

        public RealImage(string filename)
        {
            this.fileName = filename;
            LoadImageFromDisk();
            
        }

        private void LoadImageFromDisk()
        {
            Console.WriteLine($"Loading image: {fileName}");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying image: {fileName}");
        }
    }

}
