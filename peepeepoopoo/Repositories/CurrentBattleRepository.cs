using System;
using peepeepoopoo.Models.Battles;
using peepeepoopoo.Models.Pets;

namespace peepeepoopoo.Repositories
{
    public class CurrentBattleRepository
    {
        public static Battle Battle;

        public static Pet Enemy;

        public static void SetBattle(Battle battle)
        {
            Battle = battle;
        }
    }
}
