using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Currency;
using peepeepoopoo.Interfaces.Shop;
namespace peepeepoopoo.Models.Shop
{

    public class ShopItemOption
    {
        public string Key;
        public object Value;

        public ShopItemOption(string key, object value)
        {
            Key = key;
            Value = value;
        }
    }

    public class ShopItem
    {
        /// <summary>
        /// Price. Can be bought with Achievement aswell, since that is also an ICurrency.
        /// </summary>
        public ICurrency Price;

        /// <summary>
        ///  Specific ShopItem ID
        /// </summary>
        public int Id;

        /// <summary>
        /// The Item purchased. Creature, Achievement, Food are ISellableItem (Is an purchasable item)
        /// </summary>
        public ISellableItem Item;

        public List<ShopItemOption> ShopItemOptions;

        public string Options;
        public ShopItem(int id, ICurrency price, ISellableItem item)
        {
            Id = id;
            Price = price;
            Item = item;
            ShopItemOptions = new List<ShopItemOption>();
        }

        public void AddItemOption(ShopItemOption option)
        {
            if(ShopItemOptions == null)
                ShopItemOptions = new List<ShopItemOption>();

            ShopItemOptions.Add(option);
        }

        public ShopItem(int id, ICurrency price, ISellableItem item, List<ShopItemOption> shopItemOptions)
        {
            Id = id;
            Price = price;
            Item = item;
            ShopItemOptions = shopItemOptions;
        }
    }
}
