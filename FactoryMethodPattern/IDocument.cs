using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public interface IDocument
    {
        void CreateDocument();
    }

    public class Resume : IDocument
    {
        public void CreateDocument()
        {
            Console.WriteLine("Resume created.");
        }
    }

    public class Report : IDocument
    {
        public void CreateDocument()
        {
            Console.WriteLine("Report created.");
        }
    }

}
