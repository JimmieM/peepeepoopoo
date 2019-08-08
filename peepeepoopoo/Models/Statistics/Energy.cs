using System;
using peepeepoopoo.Interfaces.Statistics;

namespace peepeepoopoo.Models.Statistics
{
    public class Energy : Statistic, IStatistic
    {
        public Energy(int value) : base(value)
        {
        }

        public bool IsPrimaryStat => throw new NotImplementedException();

        public string Statistic => throw new NotImplementedException();

        public int LowestValuePossible => throw new NotImplementedException();

        public int HighestValuePossible => throw new NotImplementedException();

        public int OverFeedingLimit => throw new NotImplementedException();
    }
}
