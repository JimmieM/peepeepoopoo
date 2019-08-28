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
        /// Article Number
        /// </summary>
        public string ArticleNumber;

        /// <summary>
        ///  Specific ShopItem ID
        /// </summary>
        public int Id;
        /// <summary>
        /// The Item purchased. Creature, Achievement, Food are IShopItem (Is an purchasable item)
        /// </summary>
        public IShopItem Item;

        public List<ShopItemOption> ShopItemOptions;

        public string Options;
        public ShopItem(int id, string articleNumber, ICurrency price, IShopItem item)
        {
            Id = id;
            ArticleNumber = articleNumber;
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

        public ShopItem(int id, string articleNumber, ICurrency price, IShopItem item, List<ShopItemOption> shopItemOptions)
        {
            Id = id;
            ArticleNumber = articleNumber;
            Price = price;
            Item = item;
            ShopItemOptions = shopItemOptions;
        }
    }
}
