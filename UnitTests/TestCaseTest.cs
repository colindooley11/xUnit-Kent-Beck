namespace UnitTests
{
    using System.Diagnostics;
    using XUnit;

    public class TestCaseTest : TestCase
    {
        public TestCaseTest(string name) : base(name)
        {
        }

        private void TestTemplateMethod()
        {
            var _test = new WasRun("testMethod");
            _test.Run(new TestResult());
            Debug.WriteLine($"Expected == Setup TestMethod TearDown: Actual ==   {_test.log}");
        }

        private void TestResult()
        {
            var _test = new WasRun("testMethod");
            var results = new TestResult();
            TestResult result = _test.Run(results);
            Debug.WriteLine($"Expected == 1 run, 0 failed:  Actual == {result.Summary()}");
        }

        private void TestFailedResult()
        {
            var _test = new WasRun("failedTestMethod");
            var testResults = new TestResult();
            var result = _test.Run(testResults);
            Debug.WriteLine($"Expected == 1 run, 1 failed:  Actual == {result.Summary()}");
        }

        private void TestFailedResultFormatting()
        {
            var result = new TestResult();
            result.TestStarted();
            result.TestFailed();
            Debug.WriteLine($"Expected == 1 run, 1 failed: Actual == {result.Summary()}");
        }
        
        private void TestFailedSetup()
        {
            var _test = new WasRunFailedSetup("Setup");
            var results = new TestResult();
            var result = _test.Run(results);
            // I attempted to use my new Assert Type here, other tests use Debug.WriteLine
            Assert.AreEqual("1 run, 1 failed", result.Summary());
        }
        
        private void TestSuite()
        {
            var suite = new TestSuite();
            suite.Add(new WasRun("testMethod"));
            suite.Add(new WasRun("failedTestMethod"));
            var testResults = new TestResult();
            suite.Run(testResults);
            Debug.WriteLine($"Expected == 2 run, 1 failed: Actual == {testResults.Summary()}");
        }
    }
}