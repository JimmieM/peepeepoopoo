using System;
using System.Collections.Generic;
using peepeepoopoo.Models.Pets;

namespace peepeepoopoo.Interfaces.Pets
{
    public interface IPetsService
    {
        List<Pet> GetMyPets();
        Pet GetPet(int petId);
    }
}
