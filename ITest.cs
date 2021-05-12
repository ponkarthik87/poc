using System;
using System.Collections.Generic;
using System.Text;

namespace TestBenchMark
{
    public interface ITest<in T>
    {
        void Add(IEnumerable<T> input);
        void Contains(IEnumerable<T> input);

        void Remove(IEnumerable<T> input);
    }
}
