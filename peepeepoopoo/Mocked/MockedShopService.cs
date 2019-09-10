using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Currency;
using peepeepoopoo.Interfaces.Shop;
using peepeepoopoo.Models.Shop;
using peepeepoopoo.Constants.Shop;
using peepeepoopoo.Models.Pets;
using peepeepoopoo.Models.Pets.Creatures;
using peepeepoopoo.Helpers;
using peepeepoopoo.Models.Pets.Food;

namespace peepeepoopoo.Mocked
{
    public class MockedShopService : MockedBaseService, IShopService
    {
        public MockedShopService(int userId) : base(userId)
        {
        }

        public List<ShopItem> GetShopItems()
        {
            return ShopItems.GetAll();
        }

        public ISellableItem PurchaseItem(ShopItem item)
        {
            var shopItem = item.Item;

            if(shopItem is Creature)
            {
                // create a pet.
                var option = ShopItemsHelper.GetPetName(item);
                if (option == null)
                    return null;

                var newPet = Pet.ConcreteStarterPet(shopItem as Creature, option.Value.ToString());
                PetService.AddPet(Player, newPet);
                return newPet;
            }

            if (shopItem is CreatureAttack)
            {
                var option = ShopItemsHelper.GetAttackPetId(item);
                if (option == null)
                    return null;

                try
                {
                    var petId = Convert.ToInt32(option.Value);
                    var pet = PetService.GetPet(petId);
                    pet.Attacks.Add(shopItem as CreatureAttack);

                } catch(Exception e)
                {
                    return null;
                }
         
            } else if(shopItem is Food)
            {
                Player.Food.Add(shopItem as Food);
            }
            return shopItem;
            
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
