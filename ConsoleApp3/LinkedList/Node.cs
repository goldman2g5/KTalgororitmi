using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.LinkedList
{
    internal class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public bool IsLast;

        public Node(T value)
        {
            Value = value;
        }

        public Node(T value, Node<T> next)
        {
            Value = value;
            Next = next;
        }

        public Node()
        {
        }
        public int GetLength()
        {
            var current = this;
            int count = 0;
            while (current != null)
            {
                count++;
                if (current.IsLast)
                    break;
                current = current.Next;
            }
            return count + 1;
        }
    }
}
