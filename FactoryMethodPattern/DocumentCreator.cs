using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public abstract class DocumentCreator
    {
        // The Factory Method
        public abstract IDocument CreateDocument();
    }

    public class ResumeCreator : DocumentCreator
    {
        public override IDocument CreateDocument()
        {
            return new Resume();
        }
    }

    public class ReportCreator : DocumentCreator
    {
        public override IDocument CreateDocument()
        {
            return new Report();
        }
    }



}
