using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp3
{
    internal class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node(T value)
        {
            Value = value;
        }

        public Node()
        {
        }
    }
    
    internal class LinkedList<T>
    {
        public Node<T> Node { get; set; }


        public LinkedList(Node<T> node)
        {
            Node = node;
        }

        public LinkedList(T data)
        {
            Node = new Node<T>(data);
        }

        public LinkedList()
        {
            Node = new Node<T>();
        }

        public void Add(T data)
        {
            var node = new Node<T>(data);
            if (Node == null)
            {
                Node = node;
            }
            else
            {
                var current = Node;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
        }

        public void Remove(T node)
        {
            if (Node == null)
            {
                return;
            }
            if (Node.Value.Equals(node))
            {
                Node = Node.Next;
            }
            else
            {
                var current = Node;
                while (current.Next != null)
                {
                    if (current.Next.Value.Equals(node))
                    {
                        current.Next = current.Next.Next;
                        return;
                    }
                    current = current.Next;
                }
            }
        }

        public void RemoveAt(int index)
        {
            if (Node == null)
            {
                return;
            }
            if (index == 0)
            {
                Node = Node.Next;
            }
            else
            {
                var current = Node;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = current.Next.Next;
            }
        }


        public override string ToString()
        {
            var sb = new StringBuilder();
            var current = Node;
            while (current != null)
            {
                sb.Append(current.Value);
                sb.Append(" ");
                current = current.Next;
            }
            return sb.ToString();
        }
    }
}
