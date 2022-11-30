using System;
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

        public Node(T value)
        {
            Value = value;
        }

        public Node()
        {
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
