namespace UnitTests
{
    using System;
    using XUnit;

    class Program
    {
        private static void Main()

        {
            var testSuite = new TestSuite();
            
            testSuite.Add(new TestCaseTest("TestTemplateMethod"));
            testSuite.Add(new TestCaseTest("TestResult"));
            testSuite.Add(new TestCaseTest("TestFailedResult"));
            testSuite.Add(new TestCaseTest("TestFailedResultFormatting"));
            testSuite.Add(new TestCaseTest("TestFailedSetup"));
            testSuite.Add(new TestCaseTest("TestSuite"));
            var results = new TestResult();
            testSuite.Run(results);
            Console.WriteLine(results.Summary());
            //var testCaseAssert = new TestCaseAssert("TestItemsAreEqual");
            //var summary = testCaseAssert.Run().Summary();
            //Assert.AreEqual(summary, "123");
            Console.ReadKey();
        }
    }
}