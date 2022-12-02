using ConsoleApp3.LinkedList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Sequense
{
    internal class Sequence<T> : ISequence<T>, IList<T>
    {
        private List<T> _items = new List<T>();
        public bool IsReadOnly => false;
        public int Count => _items.Count;

        public void Build(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Add((T)Convert.ChangeType(i, typeof(T)));
            }
        }

        public T this[int index] { get => _items[index]; set => _items[index] = value; }

        public void Add(T item) => _items.Add(item);

        public void AddRange(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }

        public void Clear() => _items.Clear();

        public bool Contains(T item) => _items.Contains(item);

        public void CopyTo(T[] array, int arrayIndex) => _items.CopyTo(array, arrayIndex);

        public int IndexOf(T item) => _items.IndexOf(item);

        public void Insert(int index, T item) => _items.Insert(index, item);

        public bool Remove(T item) => _items.Remove(item);

        public void RemoveAt(int index)  => _items.RemoveAt(index);

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
