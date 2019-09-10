using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces;
using peepeepoopoo.Interfaces.Battles;
using peepeepoopoo.Mocked;
using peepeepoopoo.Models.Battles;
using peepeepoopoo.Models.Pets;
using peepeepoopoo.Models.Pets.Creatures;

namespace peepeepoopoo.Services.Battles
{
    public class BattlesService : Service, IBattlesService
    {
        public BattlesService(int userId) : base(userId)
        {
            
        }

        public Battle Attack(int battleId, CreatureAttack attack, Pet damageDealer)
        {
            throw new NotImplementedException();
        }

        Battle IBattlesService.CreateBattle(Pet pet1, Pet pet2, int duration, Pet winnerPet)
        {
            throw new NotImplementedException();
        }

        Battle IBattlesService.EnterBattle(Pet pet, int id)
        {
            throw new NotImplementedException();
        }

        List<Battle> IBattlesService.GetAvailableBattles()
        {
            throw new NotImplementedException();
        }

        Battle IBattlesService.GetBattle(int id)
        {
            throw new NotImplementedException();
        }
    }
}
