using System;
using System.Collections.Generic;
using System.Text;

namespace TestBenchMark
{

    public class DictTest<T> : ITest<T>
    {
        private Dictionary<T, T> _items;

        public void Add(IEnumerable<T> input)
        {
            _items = new Dictionary<T, T>();
            foreach (var item in input)
            {
                _items.Add(item, item);
            }
        }

        public void Contains(IEnumerable<T> input)
        {
            foreach (var item in input)
            {
                 _items.ContainsKey(item);
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
