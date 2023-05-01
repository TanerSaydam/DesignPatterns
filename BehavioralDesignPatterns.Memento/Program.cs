using BehavioralDesignPatterns.Memento.Memento1;
using BehavioralDesignPatterns.Memento.Memonto2;

namespace BehavioralDesignPatterns.Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Originator originator = new();
            //CareTaker taker = new();

            //originator.SetState("Aktif");
            //taker.Save(originator);

            //originator.SetState("Pasif");
            //taker.Undo(originator);

            TextEditor textEditor = new TextEditor();
            TextEditorHistory history = new TextEditorHistory();

            textEditor.SetText("Merhaba Dünya!");
            history.Save(textEditor);

            textEditor.SetText("Merhaba Dünya! Nasılsın");
            history.Save(textEditor);

            textEditor.SetText("Merhaba Dünya! Nasılsın? İyi misin?");
            history.Undo(textEditor);

            textEditor.SetText("Merhaba Dünya! Ne var ne yok?");
            history.Redo(textEditor);
        }
    }
}