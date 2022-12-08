using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;
using ConsoleApp3.LinkedList;

namespace ConsoleApp3
{

    internal class LinkedList<T> : IEnumerable<T>
    {
        private LinkedLsNode<T> Node { get; set; }

        public int Count { get; set; }


        public LinkedList(LinkedLsNode<T> node)
        {
            Node = node;
            Count = 1;
        }

        public LinkedList(T data)
        {
            Node = new LinkedLsNode<T>(data);
            Count = 1;
        }

        public LinkedList()
        {
            Node = new LinkedLsNode<T>();
            Count = 1;
        }

        public void Add(T data)
        {
            var node = new LinkedLsNode<T>(data);
            Node ??= node;

            Node.Value ??= data;
            var current = Node;
            while (current.Next != null)
            {
                if (current.IsLast)
                    break;
                current = current.Next;
            }
            current.Next = node;
            Count++;
            LoopLast();
        }

        public int IndexOf(T item)
        {
            var current = Node;
            var index = 0;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return index;
                }
                if (current.IsLast)
                    break;
                current = current.Next;
                index++;
            }
            LoopLast();
            return -1;
        }

        public void Insert(int index, T item)
        {
            if (index == 0)
            {
                var node = new LinkedLsNode<T>(item);
                node.Next = Node;
                Node = node;
                Count++;
            }
            else
            {
                var current = Node;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                var node = new LinkedLsNode<T>(item);
                node.Next = current.Next;
                current.Next = node;
                Count++;
            }
            LoopLast();
        }


        public bool RemoveAt(int index)
        {
            if (index == 0)
            {
                Node = Node.Next;
                Count--;
                LoopLast();
                return true;
            }

            var current = Node;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            current.Next = current.Next.Next;
            Count--;
            LoopLast();
            return true;
        }


        public bool Remove(T item)
        {
            if (Node == null)
            {
                return false;
            }
            if (Node.Value.Equals(item))
            {
                Node = Node.Next;
                return false;
            }
            var current = Node;
            while (current.Next != null)
            {
                if (current.Next.Value.Equals(item))
                {
                    if (current.IsLast)
                        break;
                    current.Next = current.Next.Next;
                    return true;
                }
                current = current.Next;
                Count--;
            }
            LoopLast();

            return true;
        }

        public LinkedLsNode<T> First()
        {
            return Node;
        }

        public LinkedLsNode<T> Last()
        {
            var current = Node;
            while (current.Next != null)
            {
                current = current.Next;
                if (current.IsLast)
                    break;
            }

            current = new LinkedLsNode<T>(current.Value);
            current.Next = First();
            return current;
        }


        private void LoopLast()
        {
            var current = Node;
            while (current.Next != null)
            {
                current.IsLast = false;
                if (current.IsLast)
                    break;
                current = current.Next;
            }

            current.Next = First();
            current.IsLast = true;
        }


        public LinkedLsNode<T> this[int index]
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



        public IEnumerator<T> GetEnumerator()
        {
            var current = Node;
            while (current != null)
            {
                yield return current.Value;
                if (current.IsLast)
                    break;
                current = current.Next;
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
                if (current.IsLast)
                    break;
                current = current.Next;
            }
            return sb.ToString();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}