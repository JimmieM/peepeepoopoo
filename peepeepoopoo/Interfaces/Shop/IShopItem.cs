using System;
using peepeepoopoo.Interfaces.Currency;
using peepeepoopoo.Models.Currency;
namespace peepeepoopoo.Interfaces.Shop
{
    public interface IShopItem
    {
        int ShopItemId { get; set; }
        ICurrency Price { get; set; }
    }
}
