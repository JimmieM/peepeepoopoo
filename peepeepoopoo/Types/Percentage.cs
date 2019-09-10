using System;
namespace peepeepoopoo.Types
{
    public struct Percentage
    {
        public Percentage(int value)
        {
            if(value > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "requires 1-100 only");
            }
        }
    }
}
