using System;
using peepeepoopoo.Interfaces;
using peepeepoopoo.Interfaces.Achievements;
using peepeepoopoo.Interfaces.Battles;
using peepeepoopoo.Interfaces.Currency;
using peepeepoopoo.Interfaces.Pets;
using peepeepoopoo.Interfaces.Players;
using peepeepoopoo.Interfaces.Shop;
using peepeepoopoo.Mocked.Constants;
using peepeepoopoo.Models.Player;

namespace peepeepoopoo.Mocked
{
    public class MockedBaseService : IBaseService
    {
        protected Player Player { get; set; }

        public IAchievementsService AchievementService { get; set; }
        public IBattlesService BattleService { get; set; }
        public ICurrencyService CurrencyService { get; set; }
        public IPetsService PetService { get; set; }
        public IPlayersService PlayerService { get; set; }
        public IShopService ShopService { get; set; }

        public MockedBaseService(int userId)
        {
            SetRequesteePlayer(userId);

            AchievementService = new MockedAchievementsService(userId);
            BattleService = new MockedBattlesService(userId);
            CurrencyService = new MockedCurrencyService(userId);
            PetService = new MockedPetsService(userId);
            PlayerService = new MockedPlayersService(userId);
            ShopService = new MockedShopService(userId);
        }

        public Player GetRequesteePlayer()
        {
            return Player;
        }

        public void SetRequesteePlayer(int userId)
        {
            if (Player == null)
            {
                // Create a user.
                var mockedPlayer = MockedPlayer.GenerateFullPlayer();

                Player = mockedPlayer;
            }
        }
    }
}
