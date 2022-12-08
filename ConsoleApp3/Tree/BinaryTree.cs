using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3.Tree
{
    public class BinaryTree
    {
        internal Node Root { get; set; }

        public BinaryTree(int value)
        {
            Root = new Node(value);
        }
        public void Add(int value)
        {
            Node before = null;
            Node after = Root;

            while (after != null)
            {
                before = after;
                if (value < after.Data)
                    after = after.LeftNode;
                else if (value > after.Data)
                    after = after.RightNode;
                else
                    return;
            }

            Node newNode = new Node(value);

            if (Root == null)
                Root = newNode;
            else
            {
                if (before != null && value < before.Data)
                    before.LeftNode = newNode;
                else if (before != null) before.RightNode = newNode;
            }
        }

        public void AddRange(params int[] values)
        {
            foreach (var value in values)
            {
                Add(value);
            }
        }

        public Node Find(int value) => Find(value, Root);

        public void Remove(int value) => Root = Remove(Root, value);

        private Node Remove(Node parent, int key)
        {
            if (parent == null) return parent ?? throw new ArgumentNullException(nameof(parent));

            if (key < parent.Data)
                parent.LeftNode = Remove(parent.LeftNode, key);
            else if (key > parent.Data)
                parent.RightNode = Remove(parent.RightNode, key);

            else
            {
                if (parent.LeftNode == null)
                    return parent.RightNode;
                if (parent.RightNode == null)
                    return parent.LeftNode;

                parent.Data = MinValue(parent.RightNode);

                parent.RightNode = Remove(parent.RightNode, parent.Data);
            }

            return parent;
        }

        private int MinValue(Node node)
        {
            int minv = node.Data;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minv;
        }
        private Node Find(int value, Node parent) =>
        (parent == null
                ? null
                : value == parent.Data
                    ? parent
                    : Find(value, value < parent.Data
                        ? parent.LeftNode
                        : parent.RightNode))
            ?? throw new InvalidOperationException();

        public int GetTreeDepth() => GetTreeDepth(Root);

        private int GetTreeDepth(Node parent) => parent == null
            ? 0
            : Math.Max(GetTreeDepth(parent.LeftNode), GetTreeDepth(parent.RightNode)) + 1;

        public Node this[int index]
        {
            get
            {
                Node node = Root;
                int i = 0;
                while (node != null)
                {
                    if (i == index)
                        return node;
                    if (index < i)
                        node = node.LeftNode;
                    else
                        node = node.RightNode;
                    i++;
                }

                throw new IndexOutOfRangeException();
            }
        }
        
        public void TraversePreOrder(Node parent)
        {
            if (parent == null) return;
            Console.Write(parent.Data + " ");
            TraversePreOrder(parent.LeftNode);
            TraversePreOrder(parent.RightNode);
        }

        public void TraverseInOrder(Node parent)
        {
            if (parent == null) return;
            TraverseInOrder(parent.LeftNode);
            Console.Write(parent.Data + " ");
            TraverseInOrder(parent.RightNode);
        }

        public void TraversePostOrder(Node parent)
        {
            if (parent == null) return;
            TraversePostOrder(parent.LeftNode);
            TraversePostOrder(parent.RightNode);
            Console.Write(parent.Data + " ");
        }
    }
}
