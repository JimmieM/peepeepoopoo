using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Achievements;
using peepeepoopoo.Mocked.Constants;
using peepeepoopoo.Models.Achievements;

namespace peepeepoopoo.Mocked
{
    public class MockedAchievementsService : MockedBaseService, IAchievementsService
    {
        public MockedAchievementsService(int userId) : base(userId)
        {
        }

        public List<Achievement> GetAllAchievements()
        {
            return MockedAchievement.CreateConcreteAchievements();
        }

        public List<Achievement> GetMyAchievements()
        {
            return Player.Achievements;
        }
    }
}
