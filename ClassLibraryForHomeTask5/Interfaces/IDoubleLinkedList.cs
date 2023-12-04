using System;

namespace ClassLibraryForHomeTask5.Interfaces
{
    public interface IDoubleLinkedList<T> : ICollection<T>
    {
        void AddFirst(T item);
        void Remove(T item);
        void RemoveFirst();
        void RemoveLast();
    }
}