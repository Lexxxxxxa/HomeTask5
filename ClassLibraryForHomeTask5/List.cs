

namespace ClassLibraryForHomeTask5
{
    public class List
    {
        internal object[] items;
        public int count { get; internal set; }
        internal int capacity { get; set; }

        public List()
        {
            capacity = 4;
            items = new object[capacity];
            count = 0;
        }

        public List(int capacity)
        {
            this.capacity = capacity;
            items = new object[capacity];
            count = 0;
        }

        public object this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException();
                return items[index];
            }
            set
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException();
                items[index] = value;
            }
        }

        public void Add(object item)
        {
            items[count] = item;
            count++;
        }//5.1 Add(object)

        public void Insert(int index, object item)
        {
            if (index < 0 || index > count)
                throw new IndexOutOfRangeException();

            for (int i = count; i > index; i--)
            {
                items[i] = items[i - 1];
            }

            items[index] = item;
            count++;
        }//5.2 Insert(int, object)

        public void Remove(object item)
        {
            int index = -1;

            for (int i = 0; i < count; i++)
            {
                if (object.Equals(item, items[i]))
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                for (int i = index; i < count - 1; i++)
                {
                    items[i] = items[i + 1];
                }

                count--;
            }
        }//5.3 Remove(object)

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();

            for (int i = index; i < count - 1; i++)
            {
                items[i] = items[i + 1];
            }

            count--;
        }// 5.4 RemoveAt(int)

        public void Clear()
        {
            count = 0;
        }//5.5 Clear()

        public bool Contains(object item)
        {
            foreach (Object obj in items)
            {
                if (object.Equals(item, obj))
                    return true;
            }
            return false;
        } //5.6 bool Contains(object)

        public int IndexOf(object item)
        {
            for (int i = 0; i < count; i++)
            {
                if (object.Equals(item, items[i]))
                    return i;
            }
            return -1;
        } // 5.7 int IndexOf(object)

        public object[] ToArray()
        {
            object[] listToArray = new object[count];
            for (int i = 0; i < count; i++)
            {
                listToArray[i] = items[i];
            }
            return listToArray;
        }// 5.8 object[] ToArray()

        public void Reverse()
        {
            for (int i = 0, j = count-1; i < j; i++, j--)
            {
                object temp = items[i];
                items[i] = items[j];
                items[j] = temp;
            }
        } //5.9 Reverse()
    }
}