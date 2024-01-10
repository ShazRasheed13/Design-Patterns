using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public interface ICloneablePost
    {
        string Author { get; set; }
        string Content { get; set; }
        DateTime Timestamp { get; set; }
        ICloneablePost Clone();
        void DisplayPostInfo();
    }
}
