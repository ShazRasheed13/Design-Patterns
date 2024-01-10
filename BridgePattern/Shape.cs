using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    //Abstraction 
    public abstract class Shape
    {
        protected IRenderer renderer;

        public Shape(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public abstract void Draw();
    }

    //Refined Abstraction
    public class Circle : Shape
    {
        public Circle(IRenderer renderer) : base(renderer)
        {
        }

        public override void Draw()
        {
            Console.Write("Circle ");
            renderer.RenderShape("Circle");
        }
    }

    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer)
        {
        }

        public override void Draw()
        {
            Console.Write("Square ");
            renderer.RenderShape("Square");
        }
    }
}
