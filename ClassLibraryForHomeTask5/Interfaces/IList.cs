using System;

namespace ClassLibraryForHomeTask5.Interfaces
{
    public interface IList<T> : ICollection<T> where T : IComparable<T>
    {
        void Insert(int index, T item);
        void Remove(T item);
        void RemoveAt(int index);
        int IndexOf(T item);
        void Reverse();
    }
}