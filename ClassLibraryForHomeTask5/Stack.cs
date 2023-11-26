

namespace ClassLibraryForHomeTask5
{
    public class Stack
    {
        private List list;

        public Stack()
        {
            list = new List();
        }

        public Stack(int capacity)
        {
            list = new List(capacity);
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
                throw new InvalidOperationException("Stack is empty");

            return list[list.count - 1];
        }

        public object[] ToArray()
        {
            return list.ToArray();
        }

        public void Push(object item)
        {
            list.Add(item);
        }

        public object Pop()
        {
            if (list.count == 0)
                throw new InvalidOperationException("Stack is empty");

            object item = list[list.count - 1];
            list.RemoveAt(list.count - 1);
            return item;
        }

        public int Count
        {
            get { return list.count; }
        }
    }
}