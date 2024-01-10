using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class CompositeGraphic
    {
        private List<IGraphic> graphics = new List<IGraphic>();

        public void Add(IGraphic graphic)
        {
            graphics.Add(graphic);
        }

        public void Remove(IGraphic graphic)
        {
            graphics.Remove(graphic);
        }

        public void Draw()
        {
            foreach (var graphic in graphics)
            {
                graphic.Draw();
            }
        }
    }
}
