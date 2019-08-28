using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Achievements;
using peepeepoopoo.Models.Battles;

namespace peepeepoopoo.Models.Achievements
{
    /// <summary>
    /// Holds an achievement with its rules etc
    /// </summary>
    public class ExtendedAchievement : Achievement
    {
        public List<Reward> Rewards;
        public List<AchievementRequirement> AchievementRequirements;

        /// <summary>
        /// Holds the treeroot value
        /// </summary>
        public string TreeRoot;

        /// <summary>
        /// Holds the subroot
        /// </summary>
        public string SubRoot;


        public ExtendedAchievement(Achievement achievement) : base(achievement.Id, achievement.Name, achievement.Description, achievement.Value) { }

        public ExtendedAchievement(
            Achievement achievement,
            List<Reward> rewards,
            List<AchievementRequirement> achievementRequirements,
            string treeRoot,
            string subRoot) : base(achievement.Id, achievement.Name, achievement.Description, achievement.Value)
        {
            Rewards = rewards;
            AchievementRequirements = achievementRequirements;
            TreeRoot = treeRoot;
            SubRoot = subRoot;    
        }
    }
}
