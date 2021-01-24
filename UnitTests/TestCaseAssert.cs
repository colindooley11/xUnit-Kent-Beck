namespace UnitTests
{
    using System;
    using System.Diagnostics;
    using XUnit;

    public class TestCaseAssert : TestCase
    {
        public TestCaseAssert(string name) : base(name)
        {
        }

        private void TestItemsAreEqualIsNotTrue()
        {
            try
            {
                Assert.AreEqual(1, 2);
            }
            catch (TestRunException e)
            {
                Debug.WriteLine($"Expected: 'blah blah, Actual: {e.Message}");
                throw;
            }
        }
    }

   
}