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

        //IAchievementsService AchievementService { get; }
        //IBattlesService BattleService { get; }
        //ICurrencyService CurrencyService { get; }
        //IPetsService PetService { get; }
        //IPlayersService PlayerService { get; }
        //IShopService ShopService { get; }
    }
}
