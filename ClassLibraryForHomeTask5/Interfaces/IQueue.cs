using System;

namespace ClassLibraryForHomeTask5.Interfaces
{
    public interface IQueue<T> : ICollection<T> where T : IComparable<T>
    {
        void Enqueue(T item);
        T Dequeue();
        T Peek();
    }
}