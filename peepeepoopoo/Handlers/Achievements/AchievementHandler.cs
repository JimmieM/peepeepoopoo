using System;
using peepeepoopoo.Models.Achievements;
using peepeepoopoo.Models.Player;
using peepeepoopoo.Repositories;

namespace peepeepoopoo.Handlers.Achievements
{
    public class AchievementHandler
    {
        private static Player Player = PlayerRepository.GetPlayer();
        public static Achievement EarnAchievement(Achievement achievement)
        {
            return achievement;
        }
    }
}
