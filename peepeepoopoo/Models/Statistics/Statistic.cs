using System;
namespace peepeepoopoo.Models.Statistics
{
    public class Statistic : Parsable
    {
        public int Value {
            set
            {
                PreviousValue = Value;
                Value = value;
            }
            get
            {
                return Value;
            }
        }

        public int PreviousValue;

        public bool IsPrimaryStat;


        public Statistic(int previousValue)
        {
            PreviousValue = previousValue;
        }

        public Statistic(int value, int previousValue)
        {
            Value = value;
            PreviousValue = previousValue;
        }

        public bool StatIsAverage()
        {
            return Value > 40 && Value < 60;
        }

        public bool StatIsAboveAverage()
        {
            return Value > 64;
        }


        public bool StaticIsBelowAverage()
        {
            return Value < 37;
        }
    }
}
