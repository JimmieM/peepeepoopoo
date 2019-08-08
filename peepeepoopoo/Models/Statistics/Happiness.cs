using System;
using peepeepoopoo.Interfaces.Statistics;

namespace peepeepoopoo.Models.Statistics
{
    public class Happiness : Statistic, IStatistic
    {
        /*
         * IStatistic Implementation
         */
        public string Statistic => "Health";

        public int LowestValuePossible => 0;

        public int HighestValuePossible => 100;

        public int OverFeedingLimit => 10;

        public bool IsPrimaryStat => true;

        public Happiness(int value, int previousValue) : base(value, previousValue)
        {
        }
        public Happiness(int value) : base(value)
        {
        }


    }
}
