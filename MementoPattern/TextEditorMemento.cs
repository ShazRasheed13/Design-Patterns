using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    // Memento class
    public class TextEditorMemento
    {
        public string Text { get; }
        public TextEditorMemento(string text) 
        { Text = text;}
    }
}
