using System;
using peepeepoopoo.Interfaces.Achievements;
using peepeepoopoo.Interfaces.Battles;
using peepeepoopoo.Interfaces.Currency;
using peepeepoopoo.Interfaces.Pets;
using peepeepoopoo.Interfaces.Players;
using peepeepoopoo.Interfaces.Shop;
using peepeepoopoo.Models.Player;

namespace peepeepoopoo.Interfaces
{
    public interface IBaseService
    {
        void SetRequesteePlayer(int userId);
        Player GetRequesteePlayer();

        IAchievementsService AchievementService { get; set; }
        IBattlesService BattleService { get; set; }
        ICurrencyService CurrencyService { get; set; }
        IPetsService PetService { get; set; }
        IPlayersService PlayerService { get; set; }
        IShopService ShopService { get; set; }
    }
}
