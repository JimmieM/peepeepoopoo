using System;
using peepeepoopoo.Interfaces.Achievements;
using peepeepoopoo.Interfaces.Currency;

namespace peepeepoopoo.Models.Achievements
{
    public class Achievement : ICurrency, IBaseAchievement
    {
        /*
        * IBaseAchievement Implementation 
        */
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }

        public DateTime DateEarned;
        public bool Earned;

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
