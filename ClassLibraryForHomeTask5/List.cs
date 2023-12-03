

namespace ClassLibraryForHomeTask5
{
    public class List<T> : Interfaces.IList<T> where T : IComparable<T>
    {
        private T[] items;
        private const int DefaultCapacity = 4;

        public int Count { get; private set; }
        public int Capacity { get; private set; }

        public List()
        {
            Capacity = DefaultCapacity;
            items = new T[Capacity];
            Count = 0;
        }

        public List(int capacity)
        {
            Capacity = capacity > 0 ? capacity : DefaultCapacity;
            items = new T[Capacity];
            Count = 0;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException();

                return items[index];
            }
            set
            {
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException();

                items[index] = value;
            }
        }

        public void Add(T item)
        {
            if (Count == Capacity)
            {
                EnsureCapacity();
            }

            items[Count] = item;
            Count++;
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index > Count)
                throw new IndexOutOfRangeException("Index is out of range.");

            if (Count == Capacity)
            {
                EnsureCapacity();
            }

            for (int i = Count; i > index; i--)
            {
                items[i] = items[i - 1];
            }

            items[index] = item;
            Count++;
        }

        public void Remove(T item)
        {
            int index = IndexOf(item);

            if (index != -1)
            {
                for (int i = index; i < Count - 1; i++)
                {
                    items[i] = items[i + 1];
                }

                Count--;
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
                throw new IndexOutOfRangeException("Index is out of range.");

            for (int i = index; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }

            Count--;
        }

        public void Clear()
        {
            Count = 0;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(item, items[i]))
                    return true;
            }
            return false;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(item, items[i]))
                    return i;
            }
            return -1;
        }

        public T[] ToArray()
        {
            T[] listToArray = new T[Count];
            for (int i = 0; i < Count; i++)
            {
                listToArray[i] = items[i];
            }
            return listToArray;
        }

        public void Reverse()
        {
            for (int i = 0, j = Count - 1; i < j; i++, j--)
            {
                T temp = items[i];
                items[i] = items[j];
                items[j] = temp;
            }
        }

        private void EnsureCapacity()
        {
            Capacity *= 2;
            T[] newItems = new T[Capacity];
            for (int i = 0; i < Count; i++)
            {
                newItems[i] = items[i];
            }
            items = newItems;
        }
    }
}