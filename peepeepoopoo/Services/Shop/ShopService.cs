using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Currency;
using peepeepoopoo.Interfaces.Shop;
using peepeepoopoo.Models.Shop;

namespace peepeepoopoo.Services.Shop
{
    public class ShopService : Service, IShopService
    {
        public ShopService(int userId) : base(userId) {
        }

        public List<ShopItem> GetShopItems()
        {
            throw new NotImplementedException();
        }

        public ISellableItem PurchaseItem(ShopItem item)
        {
            throw new NotImplementedException();
        }

        public ICurrency SellItem(ShopItem item)
        {
            throw new NotImplementedException();
        }

        public bool ValidateCurrency()
        {
            throw new NotImplementedException();
        }
    }
}
