using EditorWithMemento;
using System;

namespace EditorWithMemento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test Editor Example
            TestEditorExample();
        }

        public static void TestEditorExample()
        {
            var editor = new Editor();
            var history = new History();
            editor.Content = "Test";
            history.Push(editor.CreateState());
            editor.Content = "Test 1";
            history.Push(editor.CreateState());
            editor.Content = "Test 2";
            //history.Push(editor.CreateState());
            Console.WriteLine(editor.Content);
            editor.restore(history.Pop());
            Console.WriteLine(editor.Content);
            editor.restore(history.Pop());
            Console.WriteLine(editor.Content);
            Console.ReadKey();
        }
    }
}
