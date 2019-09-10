using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Players;
using peepeepoopoo.Mocked;
using peepeepoopoo.Models.Achievements;

namespace peepeepoopoo.Controllers.Mocked.Players
{
    public class MockedGetMyAchievementsController : MockedController
    {
        public List<Achievement> GetAchievements()
        {
            return Repositories.ServicesRepository.PlayerService.GetMyAchievements();
        }
    }
}
