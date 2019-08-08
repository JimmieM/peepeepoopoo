using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces;
using peepeepoopoo.Models.Achievements;
using peepeepoopoo.Models.Currency;
using peepeepoopoo.Models.Pets;
using peepeepoopoo.Models.Pets.Creatures;
using peepeepoopoo.Models.Player;

namespace peepeepoopoo.Mocked.Constants
{
    public class MockedPlayer : MockedBase
    {
        /// <summary>
        /// Includes; Achievements, Pets, Friends
        /// </summary>
        /// <returns></returns>
        public static Player GenerateFullPlayer()
        {
            var basePlayer = GenerateBasePlayer();

            // PETS
            var pet1 = MockedPet.Create(basePlayer);
            var pet2 = MockedPet.Create(basePlayer);
            basePlayer.Pets.Add(pet1);
            basePlayer.Pets.Add(pet2);

            // TODO

            // ACHIEVEMENTS

            // FRIENDS

            return basePlayer;
        }

        /// <summary>
        /// Just base properties. No relations etc (pets, achi, friends)
        /// </summary>
        /// <returns></returns>
        public static Player GenerateBasePlayer()
        {
            // Base
            var id = GenerateId(999);
            var level = new Level(200, 20, 2000);
            var avatar = "";
            var email = "";
            var username = "";
            var latestOnline = DateTime.Now;
            var currency = new Currency(200);
            var achievements = new List<Achievement>();

            var pets = new List<Pet>();

            // Achievements extension
            achievements.Add(new Achievement(1, "Test", "Test", 50));
            achievements.Add(new Achievement(2, "Test", "Test", 50));
            achievements.Add(new Achievement(3, "Test", "Test", 50));

            return new Player(id, level, avatar, email, username, latestOnline, currency, achievements, pets);
        }
    }
}
