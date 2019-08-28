using System;
using System.Collections.Generic;
using System.Linq;
using peepeepoopoo.Interfaces.Pets;
using peepeepoopoo.Models.Pets;

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
    }
}
