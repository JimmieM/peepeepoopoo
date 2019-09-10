using System;
using peepeepoopoo.Interfaces.Currency;
using peepeepoopoo.Interfaces.Shop;
namespace peepeepoopoo.Models.Battles
{
    public class Reward
    {
        ISellableItem ShopReward;
        ICurrency Currency;
        public Reward(ISellableItem shopReward)
        {
            ShopReward = shopReward;
        }

        public Reward(ICurrency currency)
        {
            Currency = currency;
        }
    }
}
