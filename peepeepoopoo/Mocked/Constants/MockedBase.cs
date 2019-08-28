using System;
using peepeepoopoo.Interfaces;

namespace peepeepoopoo.Mocked.Constants
{
    public abstract class MockedBase
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
