using System;

namespace ClassLibraryForHomeTask5.Interfaces
{
    public interface IQueue : ICollection
    {
        void Enqueue(object item);
        object Dequeue();
        void Clear();
        bool Contains(object item);
        object Peek();
        object[] ToArray();
    }
}