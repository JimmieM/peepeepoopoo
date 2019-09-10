using peepeepoopoo.Models.Battles;
using peepeepoopoo.Models.Pets;

namespace peepeepoopoo.Controllers.Mocked.Battles
{
    public class MockedCreateBattleController : MockedController
    {
        public Battle CreateBattle(Pet pet1, Pet pet2, int duration, Pet winnerPet)
        {
            return Repositories.ServicesRepository.BattlesService.CreateBattle(pet1, pet2, duration, winnerPet);
        }
    }
}
