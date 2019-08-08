using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Battles;
using peepeepoopoo.Models.Battles;
using peepeepoopoo.Models.Pets;

namespace peepeepoopoo.Services.Battles
{
    public class BattlesService : IBattlesService
    {
        public BattlesService()
        {
        }

        public Battle CreateBattle(Pet pet1, Pet pet2, int duration, Pet winnerPet)
        {
            throw new NotImplementedException();
        }

        public Battle EnterBattle(Pet pet, int id)
        {
            throw new NotImplementedException();
        }

        public List<Battle> GetAvailableBattles()
        {
            throw new NotImplementedException();
        }
    }
}
