using ClassLibraryForHomeTask5.Interfaces;

namespace ClassLibraryForHomeTask5
{
    public class BinaryTree<T> : ITree<T> where T : IComparable<T>
    {
        private class Node
        {
            public readonly T Value;
            public Node Left;
            public Node Right;

            public Node(T value)
            {
                Value = value;
                Left = null;
                Right = null;
            }
        }

        private Node Root;
        public int Count;

        public BinaryTree()
        {
            Root = null;
            Count = 0;
        }

        public void Add(T value)
        {
            Root = AddRecursive(Root, value);
            Count++;
        }

        private Node AddRecursive(Node node, T value)
        {
            if (node == null)
            {
                return new Node(value);
            }

            int comparisonResult = value.CompareTo(node.Value);

            if (comparisonResult == 0)
            {
                return node;
            }

            if (comparisonResult < 0)
            {
                node.Left = AddRecursive(node.Left, value);
            }
            else
            {
                node.Right = AddRecursive(node.Right, value);
            }

            return node;
        }

        public bool Contains(T value)
        {
            return ContainsRecursive(Root, value);
        }

        private bool ContainsRecursive(Node node, T value)
        {
            if (node == null)
            {
                return false;
            }

            int comparisonResult = value.CompareTo(node.Value);

            if (comparisonResult == 0)
            {
                return true;
            }

            if (comparisonResult < 0)
            {
                return ContainsRecursive(node.Left, value);
            }
            else
            {
                return ContainsRecursive(node.Right, value);
            }
        }

        public void Clear()
        {
            Root = null;
            Count = 0;
        }

        public T[] ToArray()
        {
            T[] result = new T[Count];
            ToArrayRecursive(Root, result, 0);
            return result;
        }

        private int ToArrayRecursive(Node node, T[] array, int index)
        {
            if (node != null)
            {
                index = ToArrayRecursive(node.Left, array, index);
                array[index++] = node.Value;
                index = ToArrayRecursive(node.Right, array, index);
            }
            return index;
        }
    }
}