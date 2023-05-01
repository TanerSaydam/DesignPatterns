using BehavioralDesignPatterns.Memento.Memento1;
using BehavioralDesignPatterns.Memento.Memonto2;
using BehavioralDesignPatterns.Memento.Odev1;

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

            //TextEditor textEditor = new TextEditor();
            //TextEditorHistory history = new TextEditorHistory();

            //textEditor.SetText("Merhaba Dünya!");
            //history.Save(textEditor);

            //textEditor.SetText("Merhaba Dünya! Nasılsın");
            //history.Save(textEditor);

            //textEditor.SetText("Merhaba Dünya! Nasılsın? İyi misin?");
            //history.Undo(textEditor);

            //textEditor.SetText("Merhaba Dünya! Ne var ne yok?");
            //history.Redo(textEditor);

            Character character = new(100, 50, 1);
            GameState game = new GameState();

            Console.WriteLine($"Başlangıç durumu: Sağlık: {character.Health}, Enerji: {character.Energy}, Level: {character.Level}");

            game.Save(character);

            character.Health -= 20;

            Console.WriteLine($"Savaş sonrası durumu: Sağlık: {character.Health}, Enerji: {character.Energy}, Level: {character.Level}");

            game.Undo(character);

            Console.WriteLine($"Geri alınan: Sağlık: {character.Health}, Enerji: {character.Energy}, Level: {character.Level}");
        }
    }
}