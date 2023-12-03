using ClassLibraryForHomeTask5.Interfaces;

namespace ClassLibraryForHomeTask5
{
    public class Queue<T> : IQueue<T> where T : IComparable<T>
    {
        private List<T> list;

        public Queue()
        {
            list = new List<T>();
        }

        public Queue(int capacity)
        {
            list = new List<T>(capacity);
        }

        public void Enqueue(T item)
        {
            list.Add(item);
        }

        public T Dequeue()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Queue is empty");

            T item = list[0];
            list.RemoveAt(0);
            return item;
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(T item)
        {
            return list.Contains(item);
        }

        public T Peek()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Queue is empty");

            return list[0];
        }

        public T[] ToArray()
        {
            return list.ToArray();
        }

        public int Count
        {
            get { return list.Count; }
        }
    }
}