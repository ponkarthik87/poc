using System;
using System.Collections.Generic;
using System.Text;

namespace TestBenchMark
{
    public class HashSetTest<T> : ITest<T>
    {
        private HashSet<T> _items;

        public void Add(IEnumerable<T> input)
        {
            _items = new HashSet<T>();
            foreach (var item in input)
            {
                _items.Add(item);
            }
        }

        public void Contains(IEnumerable<T> input)
        {
            foreach (var item in input)
            {
                _items.Contains(item);
            }
        }

        public void Remove(IEnumerable<T> input)
        {
            foreach (var item in input)
            {
                _items.Contains(item);
            }
        }
    }
}
