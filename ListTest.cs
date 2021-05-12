using System;
using System.Collections.Generic;
using System.Text;

namespace TestBenchMark
{
    public class ListTest<T> : ITest<T>
    {
        private List<T> _items;

        public void Add(IEnumerable<T> input)
        {
            _items = new List<T>();
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
                _items.Remove(item);
            }
        }
    }
}
