using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Pets.Creatures;
using peepeepoopoo.Models.Pets.Food;

namespace peepeepoopoo.Models.Pets.Creatures
{
    public class Pig : Creature
    {
        public Pig() : base(Constants.Creatures.Creatures.CreatureTypes.Pig, 3)
        {
        }
    }
}
