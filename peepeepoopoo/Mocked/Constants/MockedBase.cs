using System;
namespace peepeepoopoo.Mocked.Constants
{
    public class MockedBase
    {
        public MockedBase()
        {
        }

        protected static int GenerateId(int maxValue = 9999)
        {
            Random rnd = new Random();
            return rnd.Next(1, maxValue);
        }
    }
}
