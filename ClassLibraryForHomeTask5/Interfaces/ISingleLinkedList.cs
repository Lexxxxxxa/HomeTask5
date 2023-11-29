using System;

namespace Interfaces
{
    public interface ISingleLinkedList : ICollection
    {
        void AddFirst(object item);
        void Insert(int index, object item);
    }
}