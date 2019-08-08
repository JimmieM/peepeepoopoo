using System;
using peepeepoopoo.Interfaces.Currency;
using peepeepoopoo.Interfaces.Shop;
namespace peepeepoopoo.Models.Shop
{

    public class ShopItem : IShopItem
    {
        public ICurrency Price;
        public string ArticleNumber;
        public int Id;
        public IShopItem Item;
        public ShopItem(int id, string articleNumber, ICurrency price, IShopItem item)
        {
            Id = id;
            ArticleNumber = articleNumber;
            Price = price;
            Item = item;
        }

        public int ShopItemId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        ICurrency IShopItem.Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
