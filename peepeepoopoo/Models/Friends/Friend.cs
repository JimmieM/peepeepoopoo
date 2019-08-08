using System;
using peepeepoopoo.Models.Player;
namespace peepeepoopoo.Models.Friends
{
    public class Friend
    {
        public Player.Player Player;

        /// <summary>
        /// Defines the Player, as the person that initated the friendship. The one who sees "Pending".
        /// </summary>
        public bool Primary;
        public Friend(Player.Player player, bool primary)
        {
            Player = player;
            Primary = primary;
        }
    }
}
