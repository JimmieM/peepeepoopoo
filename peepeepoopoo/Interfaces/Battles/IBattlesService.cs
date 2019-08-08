using System;
using System.Collections.Generic;
using peepeepoopoo.Models.Battles;
using peepeepoopoo.Models.Pets;

namespace peepeepoopoo.Interfaces.Battles
{
    public interface IBattlesService
    {
        List<Battle> GetAvailableBattles();
        Battle EnterBattle(Pet pet, int id);
        Battle CreateBattle(Pet pet1, Pet pet2, int duration, Pet winnerPet);

    }
}
