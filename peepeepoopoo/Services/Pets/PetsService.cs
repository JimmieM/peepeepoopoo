using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Pets;
using peepeepoopoo.Interfaces.Statistics;
using peepeepoopoo.Mocked.Constants;
using peepeepoopoo.Models.Pets;
using peepeepoopoo.Models.Pets.Creatures;
using peepeepoopoo.Models.Player;
using peepeepoopoo.Models.Statistics;

namespace peepeepoopoo.Services.Pets
{
    public class PetsService : Service, IPetsService
    {
        public PetsService(int userId) : base(userId)
        {
        }

        /*
         * PUBLIC
         */

        public List<Pet> GetMyPets()
        {

            var pet1 = MockedPet.Create();
            var pet2 = MockedPet.Create();
            var pet3 = MockedPet.Create();

            return new List<Pet> { pet1, pet2, pet3 };
        }
        /*
         * PRIVATE 
         */

        private void UpdatePetStat(Statistic stat)
        {
        }

        private int MinutesSinceLastFed(Pet pet)
        {
            return 30;
        }

        public Pet GetPet(int petId)
        {
            throw new NotImplementedException();
        }

        public bool AddPet(Player player, Pet pet)
        {
            throw new NotImplementedException();
        }

        public bool AddAttack(Pet pet, CreatureAttack attack)
        {
            throw new NotImplementedException();
        }

        public Pet CreatePet(string name, Player owner)
        {
            throw new NotImplementedException();
        }
    }
}
