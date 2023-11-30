using System;

namespace ClassLibraryForHomeTask5.Interfaces
{
    public interface IDoubleLinkedList : ICollection
    {
        void AddFirst(object item);
        void Remove(object item);
        void RemoveFirst();
        void RemoveLast();
    }
}