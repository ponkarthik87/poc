using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace TestBenchMark
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class CollectionsAddBenchMark
    {
        private readonly IEnumerable<int> _inputInt = Enumerable.Range(1, 100000);
        
        private readonly IEnumerable<Person> _inputPerson = Enumerable.Range(1, 100000)
            .Select(i => new Person { Name = "TestMe", Age = i });
        
        private readonly ListTest<int> _listInt = new ListTest<int>();
        private readonly HashSetTest<int> _hashSetInt = new HashSetTest<int>();
        private readonly DictTest<int> _dictInt = new DictTest<int>();

        private readonly ListTest<Person> _listPerson = new ListTest<Person>();
        private readonly HashSetTest<Person> _hashSetPerson = new HashSetTest<Person>();
        private readonly DictTest<Person> _dictPerson = new DictTest<Person>();

        [Benchmark(Baseline = true)]
        public void ListAddInt()
        {
            _listInt.Add(_inputInt);
        }

        [Benchmark]
        public void HashSetAddInt()
        {
            _hashSetInt.Add(_inputInt);
        }

        [Benchmark]
        public void DictAddInt()
        {
            _dictInt.Add(_inputInt);
        }

        [Benchmark]
        public void ListAddPerson()
        {
            _listPerson.Add(_inputPerson);
        }

        [Benchmark]
        public void HashSetAddPerson()
        {
            _hashSetPerson.Add(_inputPerson);
        }

        [Benchmark]
        public void DictAddPerson()
        {
            _dictPerson.Add(_inputPerson);
        }
    }
}
