using System;
using peepeepoopoo.Models.Player;

namespace peepeepoopoo.Repositories
{
    /// <summary>
    /// Defines the Player requestee.
    /// </summary>
    public class PlayerRepository
    {
        private static Player Player { get; set; }
        public static void SetPlayer(Player player)
        {
            Player = player;
        }

        public static Player GetPlayer()
        {
            return Player;
        }
    }
}
