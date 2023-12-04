using System;

namespace ClassLibraryForHomeTask5.Interfaces
{
    public interface IList<T> : ICollection<T>
    {
        void Insert(int index, T item);
        void Remove(T item);
        void RemoveAt(int index);
        int IndexOf(T item);
        void Reverse();
    }
}