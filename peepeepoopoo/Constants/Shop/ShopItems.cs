using System.Collections.Generic;
using peepeepoopoo.Models.Currency;
using peepeepoopoo.Models.Pets.Creatures;
using peepeepoopoo.Models.Shop;

namespace peepeepoopoo.Constants.Shop
{
    public static class ShopItems
    {
        public static List<ShopItem> GetAll()
        {
            var items = new List<ShopItem>();
            items.AddRange(GetCreatures());
            items.AddRange(GetAttacks());
            items.AddRange(GetFood());
            return items;
        }

        public static List<ShopItem> GetCreatures()
        {
            var shopItems = new List<ShopItem>();
            var creatures = Creatures.Creatures.GetCreatures();

            creatures.ForEach(creature => shopItems.Add(
                new ShopItem(creature.ShopItemId, "C", new Currency(100), creature))
            );

            return shopItems;
        }

        public static List<ShopItem> GetAttacks()
        {
            var shopItems = new List<ShopItem>();
            var attacks = Creatures.Attacks.CreatureAttacks.GetAttacks();

            attacks.ForEach(attack => shopItems.Add(
                new ShopItem(attack.Id,"A", attack.Cost, attack)
             ));

            return shopItems;
        }

        public static List<ShopItem> GetFood()
        {
            var shopItems = new List<ShopItem>();
            var food = Creatures.Food.FoodTypes.GetFoodTypes();

            food.ForEach(foo => shopItems.Add(
                new ShopItem(foo.Id, "F", foo.Currency, foo)
             ));
            return shopItems;
        }
    }

}
