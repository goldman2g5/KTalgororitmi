using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Interfaces;
using ConsoleApp3.Sequense;

namespace ConsoleApp3.Sequence
{
    internal class Set<T> : ISequence<T>
    {
        public static implicit operator Set<T>(Sequence<T> sequence)
        {
            Set<T> result = new Set<T>();
            result.AddRange(sequence.Distinct());
            return result;
        }

        private readonly List<T> _items = new List<T>();

        public bool IsReadOnly => false;
        public int Count => _items.Count;



        public void Build(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Add((T)Convert.ChangeType(i, typeof(T)));
            }
        }


        public void AddRange(IEnumerable<T> items)
        {
            foreach (var item in items.Where(x => !_items.Contains(x)))
            {
                Add(item);
            }
        }

        public bool Add(T item)
        {
            if (_items.Contains(item)) return false;
            _items.Add(item);
            return true;

        }

        public void Clear() => _items.Clear();

        public bool Contains(T item) => _items.Contains(item);

        public void CopyTo(T[] array, int arrayIndex) => _items.CopyTo(array, arrayIndex);
        
        public bool Remove(T item) => _items.Remove(item);

        public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)_items).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in _items)
            {
                sb.Append(item);
                sb.Append(" ");
            }
            return sb.ToString();
        }
    }
}
