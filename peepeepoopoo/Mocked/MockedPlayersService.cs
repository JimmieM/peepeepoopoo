using System;
using System.Linq;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Players;
using peepeepoopoo.Mocked.Constants;
using peepeepoopoo.Models.Player;
using peepeepoopoo.Models.Achievements;
using peepeepoopoo.Models.Pets;

namespace peepeepoopoo.Mocked
{
    public class MockedPlayersService : MockedBaseService, IPlayersService
    {
        public MockedPlayersService(int userId) : base(userId)
        {
        }

        public Level EarnExperience(int amount)
        {
            return Player.Level.EarnExperience(20);
        }

        public List<Player> GetAllPlayers(int range)
        {
            return MockedPlayer.GenerateFullPlayers();
        }

        public List<Achievement> GetMyAchievements()
        {
            return AchievementService.GetMyAchievements();
        }

        public List<Pet> GetMyPets()
        {
            var petsService = new MockedPetsService(Player.Id);
            return petsService.GetMyPets();
        }

        public Player GetProfile(int userId)
        {
            return MockedPlayer.GenerateFullPlayers().FirstOrDefault(x => x.Id == userId);
        }

        public Player GetProfile(string username)
        {
            return MockedPlayer.GenerateFullPlayers().FirstOrDefault(x => x.Username == username);
        }

        public Player Login(string username, string password)
        {
            return MockedPlayer.GenerateFullPlayer(username);
        }

        public Player Register(string username, string email, string password)
        {
            return MockedPlayer.GenerateFullPlayer();
        }
    }
}
