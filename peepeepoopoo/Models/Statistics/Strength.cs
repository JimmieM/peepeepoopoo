using System;
using peepeepoopoo.Interfaces.Statistics;

namespace peepeepoopoo.Models.Statistics
{
    public class Strength : Statistic, IStatistic
    {
        /*
         * IStatistic Implementation
         */
        public string Statistic => "Health";

        public int LowestValuePossible => 0;

        public int HighestValuePossible => 100;

        public int OverFeedingLimit => 10;

        public bool IsPrimaryStat => true;

        public Strength(int value, int previousValue) : base(value, previousValue)
        {
        }
        public Strength(int value) : base(value)
        {
        }


    }
}
