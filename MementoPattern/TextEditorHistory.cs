using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    // Caretaker class
    public class TextEditorHistory
    {
        private readonly List<TextEditorMemento> history = new List<TextEditorMemento>();

        public void AddSnapshot(TextEditorMemento memento)
        {
            history.Add(memento);
        }

        public TextEditorMemento GetSnapshot(int index)
        {
            if (index >= 0 && index < history.Count)
                return history[index];
            else
                return null;
        }
    }
}
