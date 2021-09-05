using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentMementoDemo
{
    public class DocumentHistory
    {
        readonly Stack<DocumentMemento> mementoHistory = new Stack<DocumentMemento>();

        public void Push(DocumentMemento memento)
        {
            mementoHistory.Push(memento);
        }

        public DocumentMemento Pop()
        {
            return mementoHistory.Pop();
        }
    }
}
