using System;
using peepeepoopoo.Interfaces.Players;
using peepeepoopoo.Mocked;
using peepeepoopoo.Models.Player;

namespace peepeepoopoo.Controllers.Mocked.Players
{
    public class MockedLoginController : MockedController
    {
        public Player Login()
        {
            const string username = "Jimmie";
            const string password = "hej123";
            return Repositories.ServicesRepository.PlayerService.Login(username, password);
        }
    }
}

