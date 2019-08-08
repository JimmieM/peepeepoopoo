using System;
using System.Collections.Generic;
using peepeepoopoo.Models.Achievements;
using peepeepoopoo.Models.Pets;
namespace peepeepoopoo.Models.Player
{
    public class Player
    {
        public int Id;
        public Level Level;
        public string Avatar;

        public string Email;
        public string Username;

        public DateTime LatestOnline;

        public Currency.Currency Currency;

        public List<Achievement> Achievements;

        public List<Pet> Pets;

        public Player(
            int id,
            Level level,
            string avatar,
            string email,
            string username,
            DateTime latestOnline,
            Currency.Currency currency,
            List<Achievement> achievements,
            List<Pet> pets)
        {
            Id = id;
            Level = level;
            Avatar = avatar;
            Email = email;
            Username = username;
            LatestOnline = latestOnline;
            Currency = currency;
            Achievements = achievements;
            Pets = pets;
        }
    }
}
