using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MementoPattern
{
    // Originator class
    public class TextEditor
    {
        private string _text = "";
        private readonly List<TextEditorMemento> undoStack = new List<TextEditorMemento>();
        private readonly List<TextEditorMemento> redoStack = new List<TextEditorMemento>();

        public void Type(string text)
        {
            undoStack.Add(new TextEditorMemento(_text));
            _text += text;
            Console.WriteLine($"Current Text: {text}");
        }

        public void Undo()
        {
            if (undoStack.Count > 0)
            {
                redoStack.Add(new TextEditorMemento(_text));
                _text = undoStack.Last().Text;
                undoStack.RemoveAt(undoStack.Count - 1);
                Console.WriteLine($"Undone. Current Text: {_text}");
            }
            else
            {
                Console.WriteLine("Undo stack is empty.");
            }
        }

        public void Redo()
        {
            if (redoStack.Count > 0)
            {
                undoStack.Add(new TextEditorMemento(_text));
                _text = redoStack.Last().Text;
                redoStack.RemoveAt(redoStack.Count - 1);
                Console.WriteLine($"Redone. Current Text: {_text}");
            }
            else
            {
                Console.WriteLine("Redo stack is empty.");
            }
        }

        public TextEditorMemento Save()
        {
            return new TextEditorMemento(_text);
        }

        public void Restore(TextEditorMemento memento)
        {
            undoStack.Add(new TextEditorMemento(_text));
            _text = memento.Text;
            Console.WriteLine($"Document restored. Current Text: {_text}");
        }
    }
}
