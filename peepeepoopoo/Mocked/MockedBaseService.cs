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

        private int UserId { get; set; }

        private IAchievementsService _achievementService;
        public IAchievementsService AchievementService
        {
            get
            {
                if (_achievementService == null)
                    return new MockedAchievementsService(UserId);
                return _achievementService;
            }
        }

        private IBattlesService _battleService;
        public IBattlesService BattleService {
            get
            {
                if (_battleService == null)
                    return new MockedBattlesService(UserId);
                return _battleService;
            }
        }

        private ICurrencyService _currencyService;
        public ICurrencyService CurrencyService
        {
            get
            {
                if (_currencyService == null)
                    return new MockedCurrencyService(UserId);
                return _currencyService;
            }
        }

        private IPetsService _petService;
        public IPetsService PetService
        {
            get
            {
                if (_petService == null)
                    return new MockedPetsService(UserId);
                return _petService;
            }
        }

        private IPlayersService _playerService;
        public IPlayersService PlayerService
        {
            get
            {
                if (_playerService == null)
                    return new MockedPlayersService(UserId);
                return _playerService;
            }
        }

        private IShopService _shopService;
        public IShopService ShopService
        {
            get
            {
                if (_shopService == null)
                    return new MockedShopService(UserId);
                return _shopService;
            }
        }

        public MockedBaseService(int userId)
        {
            SetRequesteePlayer(userId);
            UserId = userId;
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
