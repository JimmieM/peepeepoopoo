using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Players;
using peepeepoopoo.Models.Player;

namespace peepeepoopoo.Mocked
{
    public class MockedPlayersService : IPlayersService
    {
        public MockedPlayersService()
        {
        }

        public Level EarnExperience(int amount)
        {
            throw new NotImplementedException();
        }

        public List<Player> GetAllPlayers(int range)
        {
            throw new NotImplementedException();
        }

        public Player GetProfile(int userId)
        {
            throw new NotImplementedException();
        }

        public Player GetProfile(string username)
        {
            throw new NotImplementedException();
        }

        public Player Login(string usernane, string password)
        {
            throw new NotImplementedException();
        }

        public Player Register(string username, string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
