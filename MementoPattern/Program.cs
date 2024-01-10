using MementoPattern;

TextEditor textEditor = new TextEditor();
TextEditorHistory history = new TextEditorHistory();

textEditor.Type("The Memento Design Pattern\n");    
history.AddSnapshot(textEditor.Save());

textEditor.Type("How to implement it in C#\n");
history.AddSnapshot(textEditor.Save());


textEditor.Undo();
textEditor.Undo();

textEditor.Redo();
textEditor.Redo();

TextEditorMemento snapShot = history.GetSnapshot(1);
if (snapShot!=null)
    textEditor.Restore(snapShot);

