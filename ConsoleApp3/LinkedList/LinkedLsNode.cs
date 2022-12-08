using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.LinkedList
{
    internal class LinkedLsNode<T>
    {
        public T Value { get; set; }
        public LinkedLsNode<T> Next { get; set; }

        public bool IsLast;

        public LinkedLsNode(T value)
        {
            Value = value;
        }

        public LinkedLsNode(T value, LinkedLsNode<T> next)
        {
            Value = value;
            Next = next;
        }

        public LinkedLsNode()
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
