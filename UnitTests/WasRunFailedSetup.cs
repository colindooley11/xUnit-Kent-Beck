namespace UnitTests
{
    using System;
    using XUnit;

    public class WasRunFailedSetup : TestCase
    {
        public WasRunFailedSetup(string name) : base(name)
        {
        }

        public override void Setup()
        {
            throw new Exception();
        }
    }
}