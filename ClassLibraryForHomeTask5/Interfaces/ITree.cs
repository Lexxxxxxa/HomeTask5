namespace ClassLibraryForHomeTask5.Interfaces
{
    public interface ITree<T> : ICollection<T> where T : IComparable<T>
    {
        void Add(T value);
        bool Contains(T value);
    }
}