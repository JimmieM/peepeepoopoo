using System.Collections.Generic;
using peepeepoopoo.Interfaces.Currency;
using peepeepoopoo.Interfaces.Shop;

namespace peepeepoopoo.Models.Pets.Creatures { 
    public class CreatureAttack : IShopItem
    {
        /*
         * IShopItem Implementation
         */
        int IShopItem.ShopItemId { get; set; }
        ICurrency IShopItem.Price { get; set; }

        public int Id;
        public string Name;
        public string UIDName;

        public Currency.Currency Cost;

        public bool Available;

        public int Damage;
        public int Protection;

        public string Description;

        public int ProccPerBattle;

        public string Image;

        public List<Creature> Availability;

        public CreatureAttack(
            int id,
            string name,
            string uidname,
            Currency.Currency cost,
            bool available,
            int damage,
            int protection,
            string description,
            int proccPerBattle,
            string image,
            List<Creature> availability)
        {
            Id = id;
            Name = name;
            UIDName = uidname;
            Cost = cost;
            Available = available;
            Damage = damage;
            Protection = protection;
            Description = description;
            ProccPerBattle = proccPerBattle;
            Image = image;
            Availability = availability;
        }
    }
}