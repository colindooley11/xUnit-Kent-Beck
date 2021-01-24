namespace UnitTests
{
    using System;
    using XUnit;

    public class WasRun : TestCase
    {
        public string log = string.Empty;

        public WasRun(string testmethod) : base(testmethod)
        { }

        public override void Setup()
        {
            this.log = "SetUp";
        }

        private void TestMethod()
        {
            this.log += " Test Method";
        }

        public override void TearDown()
        {
            this.log += " TearDown";
        }
        
        private void FailedTestMethod()
        {
            throw new Exception();
        }
    }
}