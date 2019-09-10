using System;
using PeepeepoopooConsoleGame.Interfaces;

namespace PeepeepoopooConsoleGame.StaticScreens.Player
{
    public class PlayerScreen : IStaticScreen
    {
        public peepeepoopoo.Models.Player.Player player;
        public PlayerScreen()
        {
            Refresh();
        }

        private void Refresh()
        {
            player = peepeepoopoo.Repositories.PlayerRepository.GetPlayer();
        }

        public string Print()
        {
            return player.Username;
        }
    }
}
