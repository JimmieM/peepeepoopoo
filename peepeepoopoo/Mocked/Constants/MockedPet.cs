using System.Collections.Generic;
using peepeepoopoo.Models.Pets.Creatures;
using peepeepoopoo.Models.Pets;
using peepeepoopoo.Models.Player;
using peepeepoopoo.Constants.Creatures.Attacks;

namespace peepeepoopoo.Mocked.Constants
{
    public class MockedPet : MockedBase
    {

        /*
         * PUBLIC
         */

        public static Pet Create(Player owner)
        {
            return GeneratePet(owner);
        }

        public static Pet Create()
        {
            var mockedOwner = MockedPlayer.GenerateFullPlayer();
            return GeneratePet(mockedOwner);
        }

        public static List<CreatureAttack> GeneratePetAttacks()
        {
            var generatedAttacks = new List<CreatureAttack>();
            var constantAttacks = CreatureAttacks.GetAttacks();

            var maxValue = GenerateId(10);

            for(var i = 1; i <= maxValue; i++)
            {
                generatedAttacks.Add(constantAttacks[i]);
            }

            return generatedAttacks;
        }

       /*
        * PRIVATE
        */

        private static Pet GeneratePet(Player owner)
        {
            var id = GenerateId();
            var attacks = GeneratePetAttacks();

            // TODO
            // Random generator for Creature type here.

            var pet = Pet.ConcreteStarterPet(new Bird(), "Name");
            pet.Id = id;
            if (owner != null)
                pet.Player1 = owner;

            pet.AddAttack(attacks[id]);
            pet.AddAttack(attacks[++id]);
            pet.AddAttack(attacks[++id]);
            return pet;
        }

    }
}
