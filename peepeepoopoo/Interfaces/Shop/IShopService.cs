using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Currency;
using peepeepoopoo.Models.Shop;

namespace peepeepoopoo.Interfaces.Shop
{
    public interface IShopService
    {
        List<ShopItem> GetShopItems();
        ShopItem PurchaseItem(ShopItem item);
        ICurrency SellItem(ShopItem item);
        bool ValidateCurrency();
    }
}
