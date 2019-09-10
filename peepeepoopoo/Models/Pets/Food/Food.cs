using System;
using peepeepoopoo.Interfaces.Currency;
using peepeepoopoo.Interfaces.Shop;

namespace peepeepoopoo.Models.Pets.Food
{
    public class Food : ISellableItem
    {
        /*
         * IShopItem Implementation
         */
        private int shopItemId;
        int ISellableItem.ShopItemId
        {
            get => shopItemId;
            set => shopItemId = value;
        }

        /*
         * Food Implementation
         */
        public int Id;
        public string Name;

        public int Health;
        public int Agility;
        public int Strength;
        public int Energy;

        public ICurrency Currency;

        public Food(int id, string name, int health, int agility, int strength, int energy)
        {
            Id = id;
            Name = name;
            Health = health;
            Agility = agility;
            Strength = strength;
            Energy = energy;
        }

        public Food(int id, string name, int health, int agility, int strength, int energy, ICurrency currency)
        {
            Id = id;
            Name = name;
            Health = health;
            Agility = agility;
            Strength = strength;
            Energy = energy;
            Currency = currency;
        }

        
    }
}
