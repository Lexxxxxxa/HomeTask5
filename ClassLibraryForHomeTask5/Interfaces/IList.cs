using System;

namespace ClassLibraryForHomeTask5.Interfaces
{
    public interface IList : ICollection
    {
        void Insert(int index, object item);
        void Remove(object item);
        void RemoveAt(int index);
        int IndexOf(object item);
        void Reverse();
    }
}