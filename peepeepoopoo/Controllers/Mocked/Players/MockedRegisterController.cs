using System;
using peepeepoopoo.Interfaces.Players;
using peepeepoopoo.Mocked;
using peepeepoopoo.Models.Player;

namespace peepeepoopoo.Controllers.Mocked.Players
{
    public class MockedRegisterController : MockedController
    {
        public Player Register()
        {
            const string username = "Jimmie";
            const string email = "jimmie.magnusson@hotmail.com";
            const string password = "hej123";
            return Repositories.ServicesRepository.PlayerService.Register(username, email, password);
        }

    }
}
