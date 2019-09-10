using System.Linq;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Battles;
using peepeepoopoo.Mocked.Constants;
using peepeepoopoo.Models.Battles;
using peepeepoopoo.Models.Pets;
using peepeepoopoo.Models.Pets.Creatures;
using peepeepoopoo.Services.Battles;

namespace peepeepoopoo.Mocked
{
    public class MockedBattlesService : MockedBaseService, IBattlesService
    {

        private BattleActionsService ActionsService;
        private List<Battle> MockedBattles;

        public MockedBattlesService(int userId) : base(userId)
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
                battle.Join(pet);
            }
            return battle;
        }

        public List<Battle> GetAvailableBattles()
        {
            return MockedBattles;
        }

        public Battle GetBattle(int id)
        {
            return MockedBattles.FirstOrDefault(battle => battle.Id == id);
        }

        Battle IBattlesService.Attack(int battleId, CreatureAttack attack, Pet damageDealer)
        {
            bool procc;
            ActionsService = new BattleActionsService(GetBattle(battleId), damageDealer);
            ActionsService.Attack(attack, (didProcc) => procc = didProcc);
            return Repositories.CurrentBattleRepository.Battle;
        }
    }
}
