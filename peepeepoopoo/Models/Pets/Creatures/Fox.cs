using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Pets.Creatures;
using peepeepoopoo.Models.Pets.Food;

namespace peepeepoopoo.Models.Pets.Creatures
{
    public class Fox : Creature
    {
        public Fox() : base(Constants.Creatures.Creatures.CreatureTypes.Fox, 3)
        {
        }
    }
}
