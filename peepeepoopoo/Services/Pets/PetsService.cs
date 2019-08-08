using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Pets;
using peepeepoopoo.Interfaces.Statistics;
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

        public void GetPets(Player player)
        {
            var pets = new List<Pet>();
            pets.Add(new Pet());
            pets.Add(new Pet());

            pets.ForEach(pet => GetPet(pet.Id));
        }

        public void GetPet(int id)
        {

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
    }
}
