using System;
using peepeepoopoo.Interfaces.Battles;
using peepeepoopoo.Mocked;
using peepeepoopoo.Models.Battles;
using peepeepoopoo.Models.Pets;

namespace peepeepoopoo.Controllers.Mocked.Battles
{
    public class MockedEnterBattleController : MockedController
    {
        public Battle EnterBattle(Pet pet, int battleId)
        {
            return Repositories.ServicesRepository.BattlesService.EnterBattle(pet, battleId);
        }
    }
}
