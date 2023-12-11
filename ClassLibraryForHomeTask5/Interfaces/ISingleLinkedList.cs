using System;

namespace ClassLibraryForHomeTask5.Interfaces
{
    public interface ISingleLinkedList<T> : ICollection<T>
    {
        void AddFirst(T item);
        void Insert(int index, T item);
    }
}