using System;

namespace ClassLibraryForHomeTask5.Interfaces
{
    public interface IObservableList<T> : ICollection<T>
    {
        T this[int index] { get; set; }
        void Add(T item);
        void Insert(int index, T item);
        void Remove(T item);
        void RemoveAt(int index);
        int IndexOf(T item);
    }
}
