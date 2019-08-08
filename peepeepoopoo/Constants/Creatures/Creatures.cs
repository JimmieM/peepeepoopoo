using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Pets.Creatures;
using peepeepoopoo.Models.Pets;
using peepeepoopoo.Models.Pets.Creatures;

namespace peepeepoopoo.Constants.Creatures
{
    public static class Creatures
    {
        public static List<Creature> GetCreatures()
        {
            return new List<Creature>
            {
                new Bird()
            };
        }
    }
}
