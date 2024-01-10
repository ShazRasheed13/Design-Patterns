using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Documents
    {
        private List<IDocumentElement> elements = new List<IDocumentElement>();

        public void AddElement(IDocumentElement element)
        {
            elements.Add(element);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var element in elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
