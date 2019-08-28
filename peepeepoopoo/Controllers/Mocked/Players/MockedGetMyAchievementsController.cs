using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Players;
using peepeepoopoo.Mocked;
using peepeepoopoo.Models.Achievements;

namespace peepeepoopoo.Controllers.Mocked.Players
{
    public class MockedGetMyAchievementsController : MockedController
    {
        private IPlayersService PlayerService;
        public MockedGetMyAchievementsController()
        {
            PlayerService = new MockedPlayersService(USER_ID);
        }

        public List<Achievement> GetAchievements()
        {
            return PlayerService.GetMyAchievements();
        }
    }
}
