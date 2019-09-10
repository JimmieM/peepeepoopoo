using System;
using peepeepoopoo.Interfaces.Currency;
using peepeepoopoo.Interfaces.Shop;

namespace peepeepoopoo.Models.Shop
{
    public class CustomShopItem : ShopItem
    {
        public Player.Player Seller;
        public CustomShopItem(int id, ICurrency price, ISellableItem item, Player.Player seller) : base(id, price, item)
        {
            Seller = seller;
        }
    }
}
