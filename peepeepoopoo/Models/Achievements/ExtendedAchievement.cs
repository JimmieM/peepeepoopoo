using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Achievements;
using peepeepoopoo.Models.Battles;

namespace peepeepoopoo.Models.Achievements
{
    /// <summary>
    /// Holds an achievement with its rules etc.
    /// </summary>
    public class ExtendedAchievement : IBaseAchievement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }

        public List<Reward> Rewards;
        public List<AchievementRequirement> AchievementRequirements;

        public string TreeRoot;
        public string SubRoot;

        public void Base(Achievement achievement)
        {
            Id = achievement.Id;
            Name = achievement.Name;
            Description = achievement.Description;
            Value = achievement.Value;
        }

        public ExtendedAchievement(Achievement achievement) 
        {
            Base(achievement);
        }

        public ExtendedAchievement(
            Achievement achievement,
            List<Reward> rewards,
            List<AchievementRequirement> achievementRequirements,
            string treeRoot,
            string subRoot)
        {
            Base(achievement);
            Rewards = rewards;
            AchievementRequirements = achievementRequirements;
            TreeRoot = treeRoot;
            SubRoot = subRoot;    
        }
    }
}
