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
            var achievements = MockedAchievement.CreateConcreteAchievements();
            achievements.ForEach(x => {
                x.Earned = true;
                x.DateEarned = DateTime.Now;
            });
            return achievements;
        }

        public List<Achievement> GetMyAchievements()
        {
            return Player.Achievements;
        }
    }
}
