using System;
namespace peepeepoopoo.Models.Statistics
{
    public class Statistic
    {
        public int Value;
        public int PreviousValue;

        public bool IsPrimaryStat;

        public int LowestValuePossible;

        public int HighestValuePossible;


        public Statistic(int previousValue)
        {
            PreviousValue = previousValue;
        }

        public Statistic(int value, int previousValue)
        {
            Value = value;
            PreviousValue = previousValue;
        }

        
    }
}
