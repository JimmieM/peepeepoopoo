using System;
using peepeepoopoo.Interfaces.Achievements;
using peepeepoopoo.Interfaces.Battles;
using peepeepoopoo.Interfaces.Currency;
using peepeepoopoo.Interfaces.Pets;
using peepeepoopoo.Interfaces.Players;
using peepeepoopoo.Interfaces.Shop;
using peepeepoopoo.Mocked;
using peepeepoopoo.Services.Achievements;
using peepeepoopoo.Services.Battles;
using peepeepoopoo.Services.Currency;
using peepeepoopoo.Services.Pets;
using peepeepoopoo.Services.Players;
using peepeepoopoo.Services.Shop;

namespace peepeepoopoo.Repositories
{
    public class ServicesRepository
    {
        private static int UserId;

        /// <summary>
        /// Initiates the ServicesRepository.
        /// Shall be done in Controller that recieves the UserId by HTTP
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static bool Initiate(int userId)
        {
      
            UserId = userId;
            return true;
        }

        /// <summary>
        /// Returns a bool flag whether or not to use Mocked data.
        /// If mcoked, then used Mocked Services.
        /// </summary>
        /// <returns></returns>
        private static bool IsMocked()
        {
            return Settings.Settings.DATASERVICE == Settings.DataService.MOCKED;
        }

        private static IBattlesService _battlesService;
        public static IBattlesService BattlesService
        {
            get
            {
                if (_battlesService != null)
                    return _battlesService;
                if (IsMocked())
                    return new MockedBattlesService(UserId);
                return new BattlesService(UserId);
            }
        }

        private static IAchievementsService _achievementsService;
        public static IAchievementsService AchievementsService
        {
            get
            {
                if (_achievementsService != null)
                    return _achievementsService;
                if (IsMocked())
                    return new MockedAchievementsService(UserId);
                return new AchievementsService(UserId);
            }
        }

        private static ICurrencyService _currencyService;
        public static ICurrencyService CurrencyService
        {
            get
            {
                if (_currencyService != null)
                    return _currencyService;
                if (IsMocked())
                    return new MockedCurrencyService(UserId);
                return new CurrencyService(UserId);
            }
        }

        private static IPetsService _petService;
        public static IPetsService PetService
        {
            get
            {
                if (_petService != null)
                    return _petService;
                if (IsMocked())
                    return new MockedPetsService(UserId);
                return new PetsService(UserId);
            }
        }

        private static IPlayersService _playerService;
        public static IPlayersService PlayerService
        {
            get
            {
                if (_playerService != null)
                    return _playerService;
                if (IsMocked())
                    return new MockedPlayersService(UserId);
                return new PlayersService(UserId);
            }
        }

        private static IShopService _shopService;
        public static IShopService ShopService
        {
            get
            {
                if (_shopService != null)
                    return _shopService;
                if (IsMocked())
                    return new MockedShopService(UserId);
                return new ShopService(UserId);
            }
        }
    }
}
