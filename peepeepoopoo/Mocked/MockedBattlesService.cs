using System.Linq;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Battles;
using peepeepoopoo.Mocked.Constants;
using peepeepoopoo.Models.Battles;
using peepeepoopoo.Models.Pets;

namespace peepeepoopoo.Mocked
{
    public class MockedBattlesService : IBattlesService
    {

        public List<Battle> MockedBattles;

        public MockedBattlesService()
        {
            FillMockedBattles();
        }

        private void FillMockedBattles()
        {
            MockedBattles = new List<Battle>();
            MockedBattles.Add(MockedBattle.CreateConcreteBattle());
            MockedBattles.Add(MockedBattle.CreateConcreteBattle());
            MockedBattles.Add(MockedBattle.CreateConcreteBattle());
        }

        public Battle CreateBattle(Pet pet1, Pet pet2, int duration, Pet winnerPet)
        {
            return MockedBattle.CreateBattle(pet1, pet2, duration, winnerPet);
        }

        /// <summary>
        /// Enters the battle with ID with the pet assigned.
        /// </summary>
        /// <param name="pet">As in You, your pet</param>
        /// <param name="id">Battle ID</param>
        /// <returns></returns>
        public Battle EnterBattle(Pet pet, int id)
        {
            var battle = MockedBattles.FirstOrDefault(mockedBattle => mockedBattle.Id == id);
            if(battle != null)
            {
                battle.SecondPet = pet;
            }
            return battle;
        }

        public List<Battle> GetAvailableBattles()
        {
            return MockedBattles;
        }
    }
}
