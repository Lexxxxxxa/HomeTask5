using ClassLibraryForHomeTask5.Interfaces.CollectionInterfaces;

namespace ClassLibraryForHomeTask5
{
    public class List : IList
    {
        private object[] items;
        private const int DefaultCapacity = 4;

        public int Count { get; private set; }
        public int Capacity { get; private set; }

        public List()
        {
            Capacity = DefaultCapacity;
            items = new object[Capacity];
            Count = 0;
        }

        public List(int capacity)
        {
            Capacity = capacity > 0 ? capacity : DefaultCapacity;
            items = new object[Capacity];
            Count = 0;
        }


        public object this[int index]
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

        public void Add(object item)
        {
            if (Count == Capacity)
            {
                EnsureCapacity();
            }

            items[Count] = item;
            Count++;
        }

        public void Insert(int index, object item)
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

        public void Remove(object item)
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

        public bool Contains(object item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (object.Equals(item, items[i]))
                    return true;
            }
            return false;
        }

        public int IndexOf(object item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (object.Equals(item, items[i]))
                    return i;
            }
            return -1;
        }

        public object[] ToArray()
        {
            object[] listToArray = new object[Count];
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
                object temp = items[i];
                items[i] = items[j];
                items[j] = temp;
            }
        }

        private void EnsureCapacity()
        {
            Capacity *= 2;
            object[] newItems = new object[Capacity];
            for (int i = 0; i < Count; i++)
            {
                newItems[i] = items[i];
            }
            items = newItems;
        }
    }
}