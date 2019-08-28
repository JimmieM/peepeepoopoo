using System;
using System.Data.SqlClient;
using peepeepoopoo.Interfaces;
using peepeepoopoo.Interfaces.Achievements;
using peepeepoopoo.Interfaces.Battles;
using peepeepoopoo.Interfaces.Currency;
using peepeepoopoo.Interfaces.Pets;
using peepeepoopoo.Interfaces.Players;
using peepeepoopoo.Interfaces.Shop;
using peepeepoopoo.Models.Player;
using peepeepoopoo.Services.Achievements;
using peepeepoopoo.Services.Battles;
using peepeepoopoo.Services.Currency;
using peepeepoopoo.Services.Pets;
using peepeepoopoo.Services.Players;
using peepeepoopoo.Services.Shop;
using peepeepoopoo.Settings.Database;

namespace peepeepoopoo.Services
{
    public class Service : IBaseService
    {
        public IAchievementsService AchievementService { get; set; }
        public IBattlesService BattleService { get; set; }
        public ICurrencyService CurrencyService { get; set; }
        public IPetsService PetService { get; set; }
        public IPlayersService PlayerService { get; set; }
        public IShopService ShopService { get; set; }

        protected Database Db;

        // Defines the Player/User
        protected Player Player;

        public Service(int userId)
        {
            Db = new Database();

            AchievementService = new AchievementsService(userId);
            BattleService = new BattlesService(userId);
            CurrencyService = new CurrencyService(userId);
            PetService = new PetsService(userId);
            PlayerService = new PlayersService(userId);
            ShopService = new ShopService(userId);
        }

        public Player GetRequesteePlayer()
        {
            throw new NotImplementedException();
        }

        public void SetRequesteePlayer(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
