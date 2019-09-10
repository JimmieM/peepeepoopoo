﻿using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Pets.Creatures;
using peepeepoopoo.Models.Pets.Food;

namespace peepeepoopoo.Models.Pets.Creatures
{
    public class RedPanda : Creature
    {
        public RedPanda() : base(Constants.Creatures.Creatures.CreatureTypes.RedPanda, 3)
        {
        }
    }
}
