using System.Collections.Generic;
using peepeepoopoo.Models.Pets.Creatures;
using peepeepoopoo.Models.Pets;
using peepeepoopoo.Models.Player;
using peepeepoopoo.Constants.Creatures.Attacks;
using System;

namespace peepeepoopoo.Mocked.Constants
{
    public class MockedPet : MockedBase
    {
        private static Random rnd = new Random();
        private static List<string> PET_NAMES = new List<string> { "Peeepeepoopoo", "Sketchy" };

        /*
         * PUBLIC
         */
        public static Pet Create(Player owner, string petName)
        {
            return GeneratePet(owner, petName);
        }

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

            for(var i = 1; i <= maxValue; i++) generatedAttacks.Add(constantAttacks[i]);

            return generatedAttacks;
        }

        /*
        * PRIVATE
        */
        private static Pet GeneratePet(Player owner, string name = null, Creature creature = null)
        {
            if (creature == null)
                creature = new Bird();

            if (name == null)
                name = PET_NAMES[rnd.Next(PET_NAMES.Count)];

            var id = GenerateId();
            var attacks = GeneratePetAttacks();

            // TODO
            // Random generator for Creature type here.

            var pet = Pet.ConcreteStarterPet(creature, name);
            pet.Id = id;
            if (owner != null)
                pet.Player1 = owner;

            pet.Attacks = attacks;
            return pet;
        }

    }
}
