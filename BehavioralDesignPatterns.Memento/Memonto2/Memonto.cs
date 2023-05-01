namespace BehavioralDesignPatterns.Memento.Memonto2;

public class Memonto
{
    private readonly string _text;

    public Memonto(string text)
    {
        _text = text;
    }

    public string GetText()
    {
        return _text;
    }
}

public class TextEditor
{
    private string _text; //Akif

    public void SetText(string text)
    {
        _text = text;
        Console.WriteLine($"Metin: {text}");
    }

    public Memonto SaveText()
    {
        return new Memonto(_text);
    }

    public void RestoreText(Memonto memento)
    {
        _text = memento.GetText();
        Console.WriteLine($"Metin geri yüklendi: {_text}");
    }
}

public class TextEditorHistory
{
    private readonly Stack<Memonto> _undoStack = new();
    private readonly Stack<Memonto> _redoStack = new();

    public void Save(TextEditor textEditor)
    {
        _undoStack.Push(textEditor.SaveText());
        _redoStack.Clear();
    }

    public void Undo(TextEditor textEditor)
    {
        if(_undoStack.Count > 0 ) //ahmet -- taner -- ahmet
        {
            Memonto memonto = _undoStack.Pop();
            _redoStack.Push(textEditor.SaveText());
            textEditor.RestoreText(memonto);
        }
    }

    public void Redo(TextEditor textEditor)
    {
        if(_redoStack.Count > 0 )
        {
            Memonto memonto = _redoStack.Pop();
            _undoStack.Push(textEditor.SaveText());
            textEditor.RestoreText(memonto);
        }
    }
}
