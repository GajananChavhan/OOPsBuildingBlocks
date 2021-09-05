using System;

namespace DocumentMementoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            document.Content = "test";
            document.FontName = "test font";
            document.FontSize = 11;
            var documentHistory = new DocumentHistory();
            documentHistory.Push(document.createMemento());
            document.Content = "test 1";
            document.FontName = "test font 2";
            document.FontSize = 12;
            Console.WriteLine(document.ToString());
            document.Restore(documentHistory.Pop());
            Console.WriteLine(document.ToString());
            Console.ReadLine();
        }
    }
}
