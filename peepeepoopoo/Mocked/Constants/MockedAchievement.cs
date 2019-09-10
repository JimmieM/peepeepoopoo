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
            return Achievements.GetAllAchievements()[GenerateId(Achievements.GetAllAchievements().Count - 1)];
        }

        public static List<Achievement> CreateConcreteAchievements()
        {
            return Achievements.GetAllAchievements();
        }
    }
}
