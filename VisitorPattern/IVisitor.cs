using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public interface IVisitor
    {
        void VisitParagraph(Paragraph paragraph);
        void VisitHeading(Heading heading);
        void VisitImage(Image image);
    }

    public class RenderingVisitor : IVisitor
    {
        public void VisitParagraph(Paragraph paragraph)
        {
            Console.WriteLine("Rendering paragraph");
        }

        public void VisitHeading(Heading heading)
        {
            Console.WriteLine("Rendering heading");
        }

        public void VisitImage(Image image)
        {
            Console.WriteLine("Rendering image");
        }
    }
    public class SpellCheckingVisitor : IVisitor
    {
        public void VisitParagraph(Paragraph paragraph)
        {
            Console.WriteLine("Spell Checking Paragraph");
        }

        public void VisitHeading(Heading heading)
        {
            Console.WriteLine("Spell Checking heading");
        }

        public void VisitImage(Image image)
        {
            Console.WriteLine("Cant check for this");
        }
    }

    public class Trial : IVisitor
    {

        public void VisitParagraph(Paragraph paragraph)
        {
            int sum = 7 + 4;
            Console.WriteLine($"Length of Paragraph is {sum}");
        }

        public void VisitHeading(Heading heading)
        {
            int sum = 3 + 4;
            Console.WriteLine($"Length of Heading is {sum}");
        }

        public void VisitImage(Image image)
        {
            int size = 7 + 3;
            Console.WriteLine($"Size of Image is {size} mb");
        }
        
    }


}
