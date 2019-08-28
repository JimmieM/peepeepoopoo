using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces;
using peepeepoopoo.Models.Achievements;
using peepeepoopoo.Models.Battles;
using peepeepoopoo.Models.Currency;
using peepeepoopoo.Models.Pets;
using peepeepoopoo.Models.Player;

namespace peepeepoopoo.Mocked.Constants
{
    public class MockedBattle : MockedBase
    {
        /// <summary>
        /// As in, create a battle for someone to join.
        /// </summary>
        /// <returns></returns>
        public static Battle CreateConcreteBattle()
        {
            var mockedPet = MockedPet.Create();
            return CreateBattle(mockedPet, null, 30, mockedPet);
        }

        /// <summary>
        /// Creates a battle with a few custom parameters.
        /// </summary>
        /// <param name="pet1"></param>
        /// <param name="pet2"></param>
        /// <param name="duration"></param>
        /// <param name="winnerPet"></param>
        /// <returns></returns>
        public static Battle CreateBattle(Pet pet1, Pet pet2, int duration, Pet winnerPet)
        {
            var id = GenerateId(999);

            var currency = new Currency(200); // User will win 200 BitFunds.
            //var achievement = new Achievement(); // TODO, Implement constant for achievements!

            var reward = new Reward(currency);

            var battleType = new PVP();

            var startDate = DateTime.Now;

            var endDate = startDate.AddMinutes(duration);

            var battle = new Battle(id, pet1, pet2, reward, battleType, startDate, endDate, winnerPet);
            return battle;
        }
    }
}
