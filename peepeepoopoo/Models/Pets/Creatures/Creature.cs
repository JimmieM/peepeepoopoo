using System.Collections.Generic;
using System.Linq;
using peepeepoopoo.Models.Pets.Creatures;
using peepeepoopoo.Interfaces.Shop;
using peepeepoopoo.Constants.Creatures.Attacks;
using static peepeepoopoo.Constants.Creatures.Creatures;

namespace peepeepoopoo.Models.Pets
{
    public class Creature : ISellableItem
    {
        /// <summary>
        /// Set the creatureType and amount of Stages.
        /// </summary>
        /// <param name="creatureType">creatureType</param>
        /// <param name="stages">stages</param>
        public Creature(CreatureTypes creatureType, int stages)
        {
            CreatureType = creatureType;
            Stages = stages;
        }
        /**
         * Creature Overridables
         */
        protected CreatureTypes CreatureType;
        protected int Stages;


        private int shopItemId;
        int ISellableItem.ShopItemId
        {
            get => shopItemId;
            set => shopItemId = value;
        }

        public List<CreatureAttack> GetAvailableAttacksAsCreature()
        {                
            return (List<CreatureAttack>)CreatureAttacks.GetAttacks().Where(attack => attack.Availability.Contains(CreatureType));
        }
    }
}
