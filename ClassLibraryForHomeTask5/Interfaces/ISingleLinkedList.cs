using System;

namespace ClassLibraryForHomeTask5.Interfaces
{
    public interface ISingleLinkedList : ICollection
    {
        void AddFirst(object item);
        void Insert(int index, object item);
    }
}