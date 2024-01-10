using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class ProxyImage: Image
    {
        private string fileName;
        private RealImage realImage;
        public ProxyImage(string filename)
        {
            this.fileName = filename;
        }
        public void Display()
        {
            if (realImage == null)
            {
                realImage = new RealImage(fileName);
            }
            realImage.Display();
        }
    }
}
