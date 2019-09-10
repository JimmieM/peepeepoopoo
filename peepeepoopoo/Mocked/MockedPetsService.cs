using System;
using System.Collections.Generic;
using System.Linq;
using peepeepoopoo.Interfaces.Pets;
using peepeepoopoo.Models.Pets;
using peepeepoopoo.Models.Pets.Creatures;
using peepeepoopoo.Models.Player;

namespace peepeepoopoo.Mocked
{
    public class MockedPetsService : MockedBaseService, IPetsService
    {
        public MockedPetsService(int userId) : base(userId){}

        public List<Pet> GetMyPets()
        {
            return Player.Pets;
        }

        public Pet GetPet(int petId)
        {
            return Player.Pets.FirstOrDefault(pet => pet.Id == petId);
        }

        public bool AddPet(Player player, Pet pet)
        {
            if (player.Id == Player.Id)
                Player.Pets.Add(pet);
            else
                player.Pets.Add(pet);
            return true;
        }

        public bool AddAttack(Pet pet, CreatureAttack attack)
        {
            var isMyPet = GetMyPets().FirstOrDefault(x => x.Id == pet.Id);

            if (isMyPet != null)
                isMyPet.Attacks.Add(attack);
            else
                pet.Attacks.Add(attack);

            return true;
        }

        public Pet CreatePet(string name, Player owner)
        {
            throw new NotImplementedException();
        }
    }
}
