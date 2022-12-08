using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Tree
{
    public class BinaryTree<T>
    {
        public TreeNode<T> root;

        public BinaryTree(T value)
        {
            root = new TreeNode<T>(value);
        }
        public BinaryTree()
        {
            root = new TreeNode<T>();
        }

        public void Add(T value)
        {
            TreeNode<T> node = root;
            TreeNode<T> nodeToAdd = new TreeNode<T>(value);
            while (node.Left != null || node.Right != null)
            {
                if (node.Left == null)
                {
                    node = node.Left;
                    break;
                }
                if (node.Right == null)
                {
                    node = node.Right;
                    break;
                }
            }

            if (node.Left == null)
            {
                node.Left = nodeToAdd;
            }

            if (node.Right == null)
            {
                node.Right = nodeToAdd;
            }

        }

        public void Print(TreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            Print(node.Left);
            Console.WriteLine(node.Value);
            Print(node.Right);
        }

        public TreeNode<T> this[int index]
        {
            get
            {
                TreeNode<T> result = root;
                for (int i = 0; i < index; i++)
                {
                    if (result.Left != null)
                    {
                        result = root.Left;
                    }
                    else if (result.Right != null)
                    {
                        result = root.Right;
                    }
                }
                return result;
            }
        }

    }
}
