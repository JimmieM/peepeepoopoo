using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces;
using peepeepoopoo.Models.Achievements;
using peepeepoopoo.Models.Currency;
using peepeepoopoo.Models.Friends;
using peepeepoopoo.Models.Pets;
using peepeepoopoo.Models.Pets.Creatures;
using peepeepoopoo.Models.Player;

namespace peepeepoopoo.Mocked.Constants
{
    public class MockedPlayer : MockedBase
    {

        private static List<string> PlayerNames = new List<string> { "Jonas", "Jimmie", "Niklas", "Alex" };

        public static List<Player> GenerateFullPlayers()
        {
            var players = new List<Player>();

            PlayerNames.ForEach(name => {

                players.Add(GenerateFullPlayer(name));
            });

            return players;
        }

        /// <summary>
        /// Includes; Achievements, Pets, Friends
        /// </summary>
        /// <returns></returns>
        public static Player GenerateFullPlayer(string username = null)
        {
            var basePlayer = GenerateBasePlayer(username);

            // LEVEL
            var level = MockedLevel.CreateConcreteLevel();
            basePlayer.Level = level;

            // PETS
            var pet1 = MockedPet.Create(basePlayer);
            var pet2 = MockedPet.Create(basePlayer);
            basePlayer.Pets.Add(pet1);
            basePlayer.Pets.Add(pet2);

            // ACHIEVEMENTS
            var achievement1 = MockedAchievement.CreateConcreteAchievement();
            var achievement2 = MockedAchievement.CreateConcreteAchievement();
            var achievement3 = MockedAchievement.CreateConcreteAchievement();
            basePlayer.Achievements.Add(achievement1);
            basePlayer.Achievements.Add(achievement2);
            basePlayer.Achievements.Add(achievement3);

            // FRIENDS
            var mockedfriend1 = GenerateBasePlayer();
            var mockedfriend2 = GenerateBasePlayer();
            var mockedfriend3 = GenerateBasePlayer();

            var friendship1 = MockedFriend.CreateFriendship(basePlayer, mockedfriend1);
            var friendship2 = MockedFriend.CreateFriendship(basePlayer, mockedfriend2);
            var friendship3 = MockedFriend.CreateFriendship(basePlayer, mockedfriend3);
            basePlayer.Friendships.Add(friendship1);
            basePlayer.Friendships.Add(friendship2);
            basePlayer.Friendships.Add(friendship3);

            // NOTIFICATIONS

            // ??

            // ??

            // END
            return basePlayer;
        }

        /// <summary>
        /// Just base properties. No relations etc (pets, achi, friends)
        /// </summary>
        /// <returns></returns>
        public static Player GenerateBasePlayer(string username = null)
        {
            // Base
            var id = GenerateId(999);
            var level = new Level(200, 20, 2000);
            var avatar = "";
            var email = "";

            if (username == null)
                username = "User_" + id.ToString();

            var latestOnline = DateTime.Now;
            var currency = new Currency(200);
            var achievements = new List<Achievement>();
            var pets = new List<Pet>();
            var friendships = new List<Friendship>();

            return new Player(id, level, avatar, email, username, latestOnline, currency, achievements, pets, friendships);
        }
    }
}
