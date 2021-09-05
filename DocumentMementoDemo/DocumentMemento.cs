using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentMementoDemo
{
    public class DocumentMemento
    {
        public DocumentMemento(string content, string fontName, int fontSize)
        {
            Content = content;
            FontName = fontName;
            FontSize = fontSize;
        }

        public string Content { get; }
        public string FontName { get; }
        public int FontSize { get; }
    }
}
