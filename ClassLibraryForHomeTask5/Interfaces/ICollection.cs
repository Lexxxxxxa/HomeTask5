

namespace ClassLibraryForHomeTask5.Interfaces
{
    public interface ICollection<T> where T : IComparable<T>
    {
        void Clear();
    }
}