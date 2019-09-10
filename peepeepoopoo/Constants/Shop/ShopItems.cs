using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Pets.Creatures;
using peepeepoopoo.Interfaces.Shop;
using peepeepoopoo.Mocked.Constants;
using peepeepoopoo.Models.Currency;
using peepeepoopoo.Models.Shop;

namespace peepeepoopoo.Constants.Shop
{
    public static class ShopItems
    {
        private static Random rnd = new Random();

        public static List<ShopItem> GetAll()
        {
            var items = new List<ShopItem>();
            items.AddRange(GetCreatures());
            items.AddRange(GetAttacks());
            items.AddRange(GetFood());
            items.AddRange(GetCustomItems());
            return items;
        }

        public static List<ShopItem> GetCreatures()
        {
            var shopItems = new List<ShopItem>();
            var creatures = Creatures.Creatures.GetCreatures();

            foreach(var creature in creatures.Values)
            {
                var c = creature as ISellableItem;
                shopItems.Add(
                    new GenericShopItem(c.ShopItemId, "C", new Currency(100), creature)
                );
            }

            return shopItems;
        }

        public static List<ShopItem> GetCustomItems()
        {
            var items = new List<ShopItem>();

            var sellers = MockedPlayer.GenerateFullPlayers();

            // Mock some items
            for (int i = 1; i < 10; i++)
            {
                var seller = sellers[rnd.Next(sellers.Count)];
                items.Add(new CustomShopItem(i, new Currency(20), MockedPet.Create(seller), seller));
            }
            return items;
        }

        public static List<ShopItem> GetAttacks()
        {
            var shopItems = new List<ShopItem>();
            var attacks = Creatures.Attacks.CreatureAttacks.GetAttacks();

            attacks.ForEach(attack => shopItems.Add(
                new GenericShopItem(attack.Id,"A", attack.Cost, attack)
             ));
            return shopItems;
        }

        public static List<ShopItem> GetFood()
        {
            var shopItems = new List<ShopItem>();
            var food = Creatures.Food.FoodTypes.GetFoodTypes();

            food.ForEach(foo => shopItems.Add(
                new GenericShopItem(foo.Id, "F", foo.Currency, foo)
             ));
            return shopItems;
        }
    }

}
