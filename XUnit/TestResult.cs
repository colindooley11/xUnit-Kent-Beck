namespace XUnit
{
    public class TestResult
    {
        private int _runCount;
        private int _failedCount;

        public TestResult()
        {
            _runCount = 0;
            _failedCount = 0;
        }

        public void TestStarted()
        {
            _runCount += 1;
        }
        
        public string Summary()
        {
            return $"{_runCount} run, {_failedCount} failed";
        }

        public void TestFailed()
        {
            _failedCount += 1;
        }
    }
}