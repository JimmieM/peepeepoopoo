using System;
using peepeepoopoo.Interfaces.Players;
using peepeepoopoo.Models.Player;
using peepeepoopoo.Services.Players;

namespace peepeepoopoo.Handlers
{
    public static class Handler
    {
        private static IPlayersService _playerService;
        private static IPlayersService PlayerService
        {
            get
            {
                if (_playerService == null)
                    _playerService = new PlayersService(1);
                return _playerService;
            }
        }

    }
}
