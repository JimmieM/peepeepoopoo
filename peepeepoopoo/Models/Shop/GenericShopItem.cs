using System;
using peepeepoopoo.Interfaces.Currency;
using peepeepoopoo.Interfaces.Shop;

namespace peepeepoopoo.Models.Shop
{
    public class GenericShopItem : ShopItem
    {
        public string ArticleNumber;
        public GenericShopItem(int id, string articleNumber, ICurrency price, ISellableItem item) : base(id, price, item)
        {
            ArticleNumber = articleNumber;
        }
    }
}
