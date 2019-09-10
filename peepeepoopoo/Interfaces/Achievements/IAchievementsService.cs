using System;
using System.Collections.Generic;
using peepeepoopoo.Models.Achievements;

namespace peepeepoopoo.Interfaces.Achievements
{
    public interface IAchievementsService : IService
    {
        List<Achievement> GetMyAchievements();
        List<Achievement> GetAllAchievements();
    }
}
