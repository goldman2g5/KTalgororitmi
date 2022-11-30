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

    internal class LinkedList<T> : IEnumerable<T>, IList<T>
    {
        private Node<T> Node { get; set; }

        public int Count { get; set; }
        public bool IsReadOnly { get; }


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
            Node ??= node;

            Node.Value ??= data; 
            var current = Node;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = node;
            Count++;
        }

        public void Clear()
        {
            Node = new Node<T>();
        }

        public bool Contains(T item) => this.Any(x => x.Equals(item));

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
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
                current = current.Next;
                index++;
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            if (index == 0)
            {
                var node = new Node<T>(item);
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
                var node = new Node<T>(item);
                node.Next = current.Next;
                current.Next = node;
                Count++;
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

        bool ICollection<T>.Remove(T item)
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
                    current.Next = current.Next.Next;
                    return true;
                }
                current = current.Next;
                Count--;
            }

            return true;
        }

        bool Remove(T item)
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
                    current.Next = current.Next.Next;
                    return true;
                }
                current = current.Next;
                Count--;
            }

            return true;
        }

        T IList<T>.this[int index]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
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

        public static int GetLength(Node<T> head)
        {
            int count = 0;
            while (head != null)
            {
                count++;
                head = head.Next;
            }
            return count;
        }


        public IEnumerator<T> GetEnumerator()
        {
            var current = Node;
            while (current != null)
            {
                yield return current.Value;
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