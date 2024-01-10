using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    // Implementor interface
    public interface IRenderer
    {
        void RenderShape(string shape);
    }

    // Concrete Implementor
    public class RedRenderer : IRenderer
    {
        public void RenderShape(string shape)
        {
            Console.WriteLine($"Rendering {shape} in red");
        }
    }

    public class BlueRenderer : IRenderer
    {
        public void RenderShape(string shape)
        {
            Console.WriteLine($"Rendering {shape} in blue");
        }
    }
}
