namespace Interfaces
{
    public interface ITree : ICollection
    {
        void Add(int value);
        bool Contains(int value);
        void Clear();
        int[] ToArray();
    }
}