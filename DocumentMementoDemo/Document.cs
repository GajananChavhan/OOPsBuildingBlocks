using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentMementoDemo
{
    public class Document
    {
        public string Content { get; set; }

        public int FontSize { get; set; }

        public string FontName { get; set; }
        public DocumentMemento createMemento()
        {
            return new DocumentMemento(Content = Content, FontName, FontSize);
        }
        public override String ToString()
        {
            return "Document{" +
                    "content='" + Content + '\'' +
                    ", fontName='" + FontName + '\'' +
                    ", fontSize=" + FontSize +
                    '}';
        }

        public void Restore(DocumentMemento memento)
        {
            this.Content = memento.Content;
            this.FontName = memento.FontName;
            this.FontSize = memento.FontSize;
        }
    }
}
