using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Achievements;
using peepeepoopoo.Mocked.Constants;
using peepeepoopoo.Models.Achievements;

namespace peepeepoopoo.Services.Achievements
{
    public class AchievementsService : Service, IAchievementsService
    {
        public AchievementsService(int userId) : base(userId){}

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
