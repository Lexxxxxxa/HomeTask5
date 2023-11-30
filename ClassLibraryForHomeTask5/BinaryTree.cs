using ClassLibraryForHomeTask5.Interfaces;

namespace ClassLibraryForHomeTask5
{
    public class BinaryTree : ITree
    {
        private class Node
        {
            public readonly int Value;
            public Node Left;
            public Node Right;

            public Node(int value)
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

        public void Add(int value)
        {
            Root = AddRecursive(Root, value);
            Count++;
        }

        private Node AddRecursive(Node node, int value)
        {
            if (node == null)
            {
                return new Node(value);
            }

            if (value == node.Value)
            {
                // Decide how to handle duplicate values.
                // Here, we are rejecting duplicates.
                return node;
            }

            if (value < node.Value)
            {
                node.Left = AddRecursive(node.Left, value);
            }
            else
            {
                node.Right = AddRecursive(node.Right, value);
            }

            return node;
        }

        public bool Contains(int value)
        {
            return ContainsRecursive(Root, value);
        }

        private bool ContainsRecursive(Node node, int value)
        {
            if (node == null)
            {
                return false;
            }

            if (value == node.Value)
            {
                return true;
            }

            if (value < node.Value)
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

        public int[] ToArray()
        {
            int[] result = new int[Count];
            ToArrayRecursive(Root, result, 0);
            return result;
        }

        private int ToArrayRecursive(Node node, int[] array, int index)
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