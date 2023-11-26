

namespace ClassLibraryForHomeTask5
{
    public class SinglyLinkedList
    {
        private class Node
        {
            public object Value;
            public Node Next;

            public Node(object value)
            {
                Value = value;
                Next = null;
            }
        }

        private Node First;
        private Node Last;
        public int Count { get; private set; }

        public SinglyLinkedList()
        {
            First = null;
            Last = null;
            Count = 0;
        }

        public void Add(object item)
        {
            Node newNode = new Node(item);

            if (First == null)
            {
                First = newNode;
                Last = newNode;
            }
            else
            {
                Last.Next = newNode;
                Last = newNode;
            }

            Count++;
        }

        public void AddFirst(object item)
        {
            Node newNode = new Node(item);

            if (First == null)
            {
                First = newNode;
                Last = newNode;
            }
            else
            {
                newNode.Next = First;
                First = newNode;
            }

            Count++;
        }

        public void Insert(int index, object item)
        {
            if (index < 0 || index > Count)
                throw new IndexOutOfRangeException();

            if (index == 0)
            {
                AddFirst(item);
            }
            else if (index == Count)
            {
                Add(item);
            }
            else
            {
                Node newNode = new Node(item);
                Node current = First;

                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }

                newNode.Next = current.Next;
                current.Next = newNode;

                Count++;
            }
        }

        public void Clear()
        {
            First = null;
            Last = null;
            Count = 0;
        }

        public bool Contains(object item)
        {
            Node current = First;

            while (current != null)
            {
                if (object.Equals(current.Value, item))
                    return true;

                current = current.Next;
            }

            return false;
        }

        public object[] ToArray()
        {
            object[] array = new object[Count];
            Node current = First;

            for (int i = 0; i < Count; i++)
            {
                array[i] = current.Value;
                current = current.Next;
            }

            return array;
        }
    }
}