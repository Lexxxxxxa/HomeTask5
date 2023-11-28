using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForHomeTask5.Interfaces
{
    namespace CollectionInterfaces
    {
        public interface IList
        {
            void Add(object item);
            void Insert(int index, object item);
            void Remove(object item);
            void RemoveAt(int index);
            void Clear();
            bool Contains(object item);
            int IndexOf(object item);
            object[] ToArray();
            void Reverse();
        }

        public interface ITree
        {
            void Add(int value);
            bool Contains(int value);
            void Clear();
            int[] ToArray();
        }

        public interface ISingleLinkedList
        {
            void Add(object item);
            void AddFirst(object item);
            void Insert(int index, object item);
            void Clear();
            bool Contains(object item);
            object[] ToArray();
        }

        public interface IDoubleLinkedList
        {
            void Add(object item);
            void AddFirst(object item);
            void Remove(object item);
            void RemoveFirst();
            void RemoveLast();
            bool Contains(object item);
            object[] ToArray();
            void Clear();
        }

        public interface IQueue
        {
            void Enqueue(object item);
            object Dequeue();
            void Clear();
            bool Contains(object item);
            object Peek();
            object[] ToArray();
        }

        public interface IStack
        {
            void Clear();
            bool Contains(object item);
            object Peek();
            object[] ToArray();
            void Push(object item);
            object Pop();
            int Count { get; }
        }

    }
}
