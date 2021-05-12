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
    public class CollectionsRemoveBenchMark
    {
        private readonly IEnumerable<int> _inputInt = Enumerable.Range(1, 100000);
        private readonly IEnumerable<int> _targetInt = Enumerable.Range(1, 100000).Where(n => n % 5 == 0);
        private readonly IEnumerable<Person> _inputPerson = Enumerable.Range(1, 100000)
            .Select(i => new Person { Name = "TestMe", Age = i });
        private readonly IEnumerable<Person> _targetPerson = Enumerable.Range(1, 100000).Where(n => n % 5 == 0)
            .Select(i => new Person { Name = "TestMe", Age = i });
        private readonly ListTest<int> _listInt = new ListTest<int>();
        private readonly HashSetTest<int> _hashSetInt = new HashSetTest<int>();
        private readonly DictTest<int> _dictInt = new DictTest<int>();

        private readonly ListTest<Person> _listPerson = new ListTest<Person>();
        private readonly HashSetTest<Person> _hashSetPerson = new HashSetTest<Person>();
        private readonly DictTest<Person> _dictPerson = new DictTest<Person>();

        public CollectionsRemoveBenchMark()
        {
            _listPerson.Add(_inputPerson);
            _hashSetPerson.Add(_inputPerson);
            _dictPerson.Add(_inputPerson);

            _listInt.Add(_inputInt);
            _hashSetInt.Add(_inputInt);
            _dictInt.Add(_inputInt);
        }

        [Benchmark(Baseline = true)]
        public void ListRemoveInt()
        {
            _listInt.Remove(_targetInt);
        }

        [Benchmark]
        public void HashSetRemoveInt()
        {
            _hashSetInt.Remove(_targetInt);
        }

        [Benchmark]
        public void DictRemoveInt()
        {
            _dictInt.Remove(_targetInt);
        }

        [Benchmark]
        public void ListRemovePerson()
        {
            _listPerson.Remove(_targetPerson);
        }

        [Benchmark]
        public void HashSetRemovePerson()
        {
            _hashSetPerson.Remove(_targetPerson);
        }

        [Benchmark]
        public void DictRemovePerson()
        {
            _dictPerson.Remove(_targetPerson);
        }
    }
}
