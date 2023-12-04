using System;

namespace ClassLibraryForHomeTask5.Interfaces
{
    public interface IStack<T> : ICollection<T>
    {
        void Push(T item);
        T Pop();
        int Count { get; }
    }
}