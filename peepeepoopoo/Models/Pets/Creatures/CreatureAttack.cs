using System.Collections.Generic;
using peepeepoopoo.Interfaces.Shop;
using peepeepoopoo.Types;
using static peepeepoopoo.Constants.Creatures.Creatures;

namespace peepeepoopoo.Models.Pets.Creatures { 
    public class CreatureAttack : ISellableItem
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

        public int Id;
        public string Name;
        public string UIDName;

        public Currency.Currency Cost;

        public bool Available;

        public int Damage;
        public int Protection;

        public string Description;

        public int ProccPerBattlePercentage;

        public string Image;

        public List<CreatureTypes> Availability;

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
            List<CreatureTypes> availability)
        {
            Id = id;
            Name = name;
            UIDName = uidname;
            Cost = cost;
            Available = available;
            Damage = damage;
            Protection = protection;
            Description = description;
            ProccPerBattlePercentage = proccPerBattle;
            Image = image;
            Availability = availability;
        }
    }
}