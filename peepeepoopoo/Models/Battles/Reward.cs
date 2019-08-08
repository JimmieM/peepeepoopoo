﻿using System;
using peepeepoopoo.Interfaces.Currency;
using peepeepoopoo.Interfaces.Shop;
namespace peepeepoopoo.Models.Battles
{
    public class Reward
    {
        IShopItem ShopReward;
        ICurrency Currency;
        public Reward(IShopItem shopReward)
        {
            ShopReward = shopReward;
        }

        public Reward(ICurrency currency)
        {
            Currency = currency;
        }
    }
}
