using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using ConsoleApp3.LinkedList;

namespace ConsoleApp3
{

    internal class LinkedList<T>
    {
        private Node<T> Node { get; set; }
        public int Count { get; set; }


        public LinkedList(Node<T> node)
        {
            Node = node;
            Count = 1;
        }

        public LinkedList(T data)
        {
            Node = new Node<T>(data);
            Count = 1;
        }

        public LinkedList()
        {
            Node = new Node<T>();
            Count = 1;
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
                Count++;
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
                    Count--;
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
                Count--;
            }
        }

        public Node<T> First()
        {
            return Node;
        }

        public Node<T> Last()
        {
            var current = Node;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current = new Node<T>(current.Value);
            current.Next = First();
            return current;
        }



        public Node<T> this[int index]
        {
            get
            {
                if (index == 0)
                    index = 1;
                if (index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }

                var current = Node;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }

                return current;
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