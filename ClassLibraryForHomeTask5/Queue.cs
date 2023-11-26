

namespace ClassLibraryForHomeTask5
{
    public class Queue
    {
        private List list;

        public Queue()
        {
            list = new List();
        }

        public Queue(int capacity)
        {
            list = new List(capacity);
        }

        public void Enqueue(object item)
        {
            list.Add(item);
        }

        public object Dequeue()
        {
            if (list.count == 0)
                throw new InvalidOperationException("Queue is empty");

            object item = list[0];
            list.RemoveAt(0);
            return item;
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(object item)
        {
            return list.Contains(item);
        }

        public object Peek()
        {
            if (list.count == 0)
                throw new InvalidOperationException("Queue is empty");

            return list[0];
        }

        public object[] ToArray()
        {
            return list.ToArray();
        }

        public int Count
        {
            get { return list.count; }
        }
    }
}