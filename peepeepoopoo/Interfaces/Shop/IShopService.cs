using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Currency;
using peepeepoopoo.Models.Shop;

namespace peepeepoopoo.Interfaces.Shop
{
    public interface IShopService : IService
    {
        List<ShopItem> GetShopItems();
        ISellableItem PurchaseItem(ShopItem item);
        ICurrency SellItem(ShopItem item);
        bool ValidateCurrency();
    }
}
