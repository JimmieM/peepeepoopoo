using System;
using System.Collections.Generic;
using peepeepoopoo.Models.Player;

namespace peepeepoopoo.Interfaces.Players
{
    public interface IPlayersService
    {
        Player Login(string usernane, string password);
        Player Register(string username, string email, string password);
        List<Player> GetAllPlayers(int range);
        Level EarnExperience(int amount);
        Player GetProfile(int userId);
        Player GetProfile(string username);
    }
}
