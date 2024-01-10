using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    // Component interface
    public interface IGraphic
    {
        void Draw();
    }

    // Leaf class representing an individual shape
    public class  Square: IGraphic
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Square");
        }
    }

    public class Circle : IGraphic
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }
}
