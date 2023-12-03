using ClassLibraryForHomeTask5.Interfaces;
using System;
using System.Collections.Generic;

namespace ClassLibraryForHomeTask5
{
    public class Stack<T> : IStack<T> where T : IComparable<T>
    {
        private List<T> list;

        public Stack()
        {
            list = new List<T>();
        }

        public Stack(int capacity)
        {
            list = new List<T>(capacity);
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
                throw new InvalidOperationException("Stack is empty");

            return list[list.Count - 1];
        }

        public T[] ToArray()
        {
            return list.ToArray();
        }

        public void Push(T item)
        {
            list.Add(item);
        }

        public T Pop()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            T item = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return item;
        }

        public int Count
        {
            get { return list.Count; }
        }
    }
}
