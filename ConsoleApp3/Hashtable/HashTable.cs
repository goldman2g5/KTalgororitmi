using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Hashtable
{
    abstract class HashTable
    {
        protected Dictionary<int, int> dict = new Dictionary<int, int>();

        public int GetHash(int key) => dict[key];
        public abstract void Add(int value);

        public abstract void Print();

    }
}
