﻿using System;
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
    }
}