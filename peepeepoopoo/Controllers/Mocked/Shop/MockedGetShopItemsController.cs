using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Shop;
using peepeepoopoo.Mocked;
using peepeepoopoo.Models.Shop;

namespace peepeepoopoo.Controllers.Mocked.Shop
{
    public class MockedGetShopItemsController : MockedController
    {
        public List<ShopItem> GetAllShopItems()
        {
            return Repositories.ServicesRepository.ShopService.GetShopItems();
        }
    }
}
