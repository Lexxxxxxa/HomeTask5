using System;

namespace ClassLibraryForHomeTask5.Interfaces
{
    public interface IStack : ICollection
    {
        void Clear();
        bool Contains(object item);
        object Peek();
        object[] ToArray();
        void Push(object item);
        object Pop();
        int Count { get; }
    }
}