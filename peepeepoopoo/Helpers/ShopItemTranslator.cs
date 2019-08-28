using System;
using System.Linq;
using peepeepoopoo.Models.Shop;

namespace peepeepoopoo.Helpers
{
    public static class ShopItemsHelper
    {
        public static string PET_NAME = "pet_name";
        public static string PET_ID = "pet_id";
      
        public static ShopItemOption GetPetName(ShopItem item)
        {
            return item.ShopItemOptions.FirstOrDefault(option => option.Key == PET_NAME);
        }

        public static ShopItemOption GetAttackPetId(ShopItem item)
        {
            return item.ShopItemOptions.FirstOrDefault(option => option.Key == PET_ID);
        }

    }
}
