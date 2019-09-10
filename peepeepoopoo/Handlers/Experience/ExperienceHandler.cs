using System;
using peepeepoopoo.Models.Player;
using peepeepoopoo.Repositories;

namespace peepeepoopoo.Handlers.Experience
{
    public class ExperienceHandler
    {
        private static Player Player = PlayerRepository.GetPlayer();
        public static Level EarnExperience(int amount)
        {
            return Player.Level.EarnExperience(amount);
        }
        public static Level EarnExperience(Player player, int amount)
        {
            return player.Level.EarnExperience(amount);
        }
    }
}
