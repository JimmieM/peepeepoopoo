using System.Collections.Generic;
using peepeepoopoo.Models.Pets;
using peepeepoopoo.Models.Pets.Creatures;
using peepeepoopoo.Models.Player;

namespace peepeepoopoo.Interfaces.Pets
{
    public interface IPetsService : IService
    {
        List<Pet> GetMyPets();
        Pet GetPet(int petId);
        bool AddPet(Player player, Pet pet);
        bool AddAttack(Pet pet, CreatureAttack attack);
        Pet CreatePet(string name, Player owner);
    }
}
