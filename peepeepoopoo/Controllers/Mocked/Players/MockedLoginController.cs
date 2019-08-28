using System;
using peepeepoopoo.Interfaces.Players;
using peepeepoopoo.Mocked;
using peepeepoopoo.Models.Player;

namespace peepeepoopoo.Controllers.Mocked.Players
{
    public class MockedLoginController : MockedController
    {
        private IPlayersService PlayerService;
        public MockedLoginController()
        {
            PlayerService = new MockedPlayersService(USER_ID);
        }

        public Player Login()
        {
            const string username = "Jimmie";
            const string password = "hej123";
            return PlayerService.Login(username, password);
        }
    }
}

