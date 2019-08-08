using System;
using peepeepoopoo.Interfaces.Shop;
using peepeepoopoo.Models.Shop;

namespace peepeepoopoo.Services.Shop
{
    public class ShopService : Service
    {
        public ShopService(int userId) : base(userId) {
        }

        public void GetShopItems()
        {
        }

        public void PurchaseItem(ShopItem item)
        {
        }

        public void SellItem(ShopItem item)
        {
        }

        public void ValidateCurrency()
        {
        }
    }
}
