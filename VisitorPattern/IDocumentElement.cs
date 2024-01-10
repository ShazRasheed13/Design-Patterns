using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public interface IDocumentElement
    {
        void Accept(IVisitor visitor);
    }

    public class Paragraph : IDocumentElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitParagraph(this);
        }
    }

    public class Heading : IDocumentElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitHeading(this);
        }
    }

    public class Image : IDocumentElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitImage(this);
        }
    }
}
