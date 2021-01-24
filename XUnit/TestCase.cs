namespace XUnit
{
    using System.Reflection;

    public class TestCase
    {
        protected string TestMethod;

        public virtual void Setup()
        {
        }

        public virtual void TearDown()
        {
        }
        
        public TestCase(string name)
        {
            TestMethod = name;
        }

        public TestResult Run(TestResult results)
        {
            results.TestStarted();
            try
            {
                Setup();
            }
            catch
            {
                results.TestFailed();
                return results; 
            }
          
            try
            {
                var method = this.GetType().GetMethod(this.TestMethod,
                    BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.IgnoreCase);
                method?.Invoke(this, null);
            }
            catch
            {
                results.TestFailed();
            }

            TearDown();
            return results;
        }
    }
}