using System;
using peepeepoopoo.Interfaces.Currency;

namespace peepeepoopoo.Models.Achievements
{
    public class Achievement : ICurrency
    {
        public int Id;
        public string Name;
        public string Description;
        public int Value;

        public bool Earned;
        public DateTime DateEarned;

        public Achievement(int id, string name, string desc, int value, bool earned, DateTime dateEarned)
        {
            Id = id;
            Name = name;
            Description = desc;
            Value = value;
            DateEarned = dateEarned;
            Earned = earned;
        }
        public Achievement(int id, string name, string desc, int value)
        {
            Id = id;
            Name = name;
            Description = desc;
            Value = value;
            Earned = false;
        }
    }
}
