using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Pets.Creatures;
using peepeepoopoo.Models.Pets.Food;

namespace peepeepoopoo.Models.Pets.Creatures
{
    public class Turtle : Creature
    {
        public Turtle() : base(Constants.Creatures.Creatures.CreatureTypes.Turtle, 3)
        {
        }
    }
}
