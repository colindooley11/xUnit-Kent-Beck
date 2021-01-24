namespace XUnit
{
    using System.Collections.Generic;

    public class TestSuite 
    {
        private readonly List<TestCase> _testCases = new();
        public void Add(object testCase)
        {
            _testCases.Add((TestCase)testCase);
        }

        public void Run(TestResult results)
        {
            foreach (var test in _testCases)
            {
                test.Run(results);
            }
        }
    }
}