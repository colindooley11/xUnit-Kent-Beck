namespace XUnit
{
    public class Assert
    {
        public static void AreEqual(object expected, object actual)
        {
            if (!expected.Equals(actual))
            {
                throw new TestRunException();
            }
        }
    }
}