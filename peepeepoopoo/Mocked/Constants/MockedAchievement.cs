using System;
using System.Collections.Generic;
using peepeepoopoo.Constants.Achievements;
using peepeepoopoo.Models.Achievements;

namespace peepeepoopoo.Mocked.Constants
{
    public class MockedAchievement : MockedBase
    {
        public static Achievement CreateConcreteAchievement()
        {
            var allAchievements = Achievements.GetAllAchievements();
            var randomAchievementIndex = GenerateId(allAchievements.Count - 1);
            return allAchievements[randomAchievementIndex];
        }

        public static List<Achievement> CreateConcreteAchievements()
        {
            return Achievements.GetAllAchievements();
        }
    }
}
