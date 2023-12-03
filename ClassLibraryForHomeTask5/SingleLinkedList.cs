using ClassLibraryForHomeTask5.Interfaces;

namespace ClassLibraryForHomeTask5
{
    public class SinglyLinkedList<T> : ISingleLinkedList<T> where T : IComparable<T>
    {
        private class Node
        {
            public readonly T Value;
            public Node Next;

            public Node(T value)
            {
                Value = value;
                Next = null;
            }
        }

        private Node First;
        private Node Last;
        public int Count { get; private set; }

        public void Add(T item)
        {
            AddLast(item);
        }

        public void AddFirst(T item)
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

        public void AddLast(T item)
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

        public void Insert(int index, T item)
        {
            if (index < 0 || index > Count)
                throw new IndexOutOfRangeException();

            if (index == 0)
            {
                AddFirst(item);
            }
            else if (index == Count)
            {
                AddLast(item);
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

        public bool Contains(T item)
        {
            Node current = First;

            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Value, item))
                    return true;

                current = current.Next;
            }

            return false;
        }

        public T[] ToArray()
        {
            T[] array = new T[Count];
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
