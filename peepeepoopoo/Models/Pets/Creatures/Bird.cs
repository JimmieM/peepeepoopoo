using peepeepoopoo.Interfaces.Shop;
using peepeepoopoo.Constants.Shop;
using peepeepoopoo.Constants.Creatures.Food;
using peepeepoopoo.Interfaces.Pets.Creatures;
using System.Collections.Generic;
using static peepeepoopoo.Constants.Creatures.Creatures;
using peepeepoopoo.Constants.Creatures;

namespace peepeepoopoo.Models.Pets.Creatures
{
    public class Bird : Creature
    {
        public Bird() : base(CreatureTypes.Bird, 1)
        {
        }
    }
}
