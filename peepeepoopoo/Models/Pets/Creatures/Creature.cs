using System.Collections.Generic;
using System.Linq;
using peepeepoopoo.Models.Pets.Food;
using peepeepoopoo.Models.Pets.Creatures;
using peepeepoopoo.Interfaces.Shop;
using peepeepoopoo.Interfaces.Currency;

namespace peepeepoopoo.Models.Pets
{
    public class Creature : IShopItem
    {
        public Creature()
        {
        }

        public int ShopItemId => 10;


        //public List<CreatureAttack> GetAvailableAttacks(Creature creature)
        //{
        //    return CreatureAttacks.Get().Where(attack => attack.Availability.Select(findByCreature => findByCreature.GetType().Equals(creature.GetType()));
        //}
    }
}
