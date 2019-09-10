using System;
using System.Collections.Generic;
using peepeepoopoo.Models.Pets;
using peepeepoopoo.Models.Pets.Creatures;

namespace peepeepoopoo.Constants.Creatures
{
    public static class Creatures
    {

        public enum CreatureTypes {
            Fox, Pig, Bird, RedPanda, Squirell, Turtle
        }

        public static Dictionary<CreatureTypes, Creature> GetCreatures()
        {
            return new Dictionary<CreatureTypes, Creature>
            {
                { CreatureTypes.Fox, new Bird() },
                { CreatureTypes.Fox, new Fox() },
                { CreatureTypes.Pig, new Pig() },
                { CreatureTypes.RedPanda, new RedPanda() },
                { CreatureTypes.Squirell, new Squirell() },
                { CreatureTypes.Turtle, new Turtle() }
            };
        }
    }
}
