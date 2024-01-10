using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FlyweightPattern
{
    public interface ITree
    {
        void Display(int x, int y);
    }

    public class TreeType : ITree
    {
        private string name;
        private string color;

        public TreeType(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        public void Display(int x, int y)
        {
            Console.WriteLine($"Tree: {name}, Color: {color}, Position: ({x}, {y})");
        }
    }
}
