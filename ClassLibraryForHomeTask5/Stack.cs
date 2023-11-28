using ClassLibraryForHomeTask5.Interfaces.CollectionInterfaces;

namespace ClassLibraryForHomeTask5
{
    public class Stack : IStack
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
            if (list.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            return list[list.Count - 1];
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
            if (list.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            object item = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return item;
        }

        public int Count
        {
            get { return list.Count; }
        }
    }
}