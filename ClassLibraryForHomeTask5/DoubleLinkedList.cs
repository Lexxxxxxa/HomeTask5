﻿using ClassLibraryForHomeTask5.Interfaces;

namespace ClassLibraryForHomeTask5
{
    public class DoublyLinkedList<T> : IDoubleLinkedList<T>
    {
        private class Node
        {
            public readonly T Value;
            public Node Next;
            public Node Previous;

            public Node(T value)
            {
                Value = value;
                Next = null;
                Previous = null;
            }
        }

        private Node First;
        private Node Last;
        public int Count { get; private set; }

        public DoublyLinkedList()
        {
            First = null;
            Last = null;
            Count = 0;
        }

        public void Add(T item)
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
                newNode.Previous = Last;
                Last = newNode;
            }

            Count++;
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
                First.Previous = newNode;
                First = newNode;
            }

            Count++;
        }

        public void Remove(T item)
        {
            Node current = First;

            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Value, item))
                {
                    if (current.Previous != null)
                        current.Previous.Next = current.Next;
                    else
                        First = current.Next;

                    if (current.Next != null)
                        current.Next.Previous = current.Previous;
                    else
                        Last = current.Previous;

                    Count--;
                    return;
                }

                current = current.Next;
            }
        }

        public void RemoveFirst()
        {
            if (First == null)
                throw new InvalidOperationException("List is empty");

            First = First.Next;

            if (First != null)
                First.Previous = null;
            else
                Last = null;

            Count--;
        }

        public void RemoveLast()
        {
            if (Last == null)
                throw new InvalidOperationException("List is empty");

            Last = Last.Previous;

            if (Last != null)
                Last.Next = null;
            else
                First = null;

            Count--;
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