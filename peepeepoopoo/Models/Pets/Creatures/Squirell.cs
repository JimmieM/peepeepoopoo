using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Pets.Creatures;
using peepeepoopoo.Models.Pets.Food;

namespace peepeepoopoo.Models.Pets.Creatures
{
    public class Squirell : Creature
    {
        public Squirell() : base(Constants.Creatures.Creatures.CreatureTypes.Squirell, 3)
        {
        }
    }
}
