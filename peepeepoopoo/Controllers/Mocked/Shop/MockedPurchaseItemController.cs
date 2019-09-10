using peepeepoopoo.Helpers;
using peepeepoopoo.Models.Pets;

namespace peepeepoopoo.Controllers.Mocked.Shop
{
    public class MockedPurchaseItemController : MockedController
    {
        /// <summary>
        /// Purchases the first pet in List of Buyable Creatures.
        /// </summary>
        /// <returns>bool</returns>
        public Pet PurchaseRandomPet(string name)
        {
            var item = Constants.Shop.ShopItems.GetCreatures()[0];

            // Set name
            item.AddItemOption(new Models.Shop.ShopItemOption(ShopItemsHelper.PET_NAME, name));

            var itemBack = Repositories.ServicesRepository.ShopService.PurchaseItem(item);
            return itemBack as Pet;
        }

        /// <summary>
        /// Purchases the first attack in List of attacks.
        /// Appends the Attack to given pet.
        /// </summary>
        /// <returns>bool</returns>
        public bool PurchaseRandomAttack(Pet pet)
        {
            var item = Constants.Shop.ShopItems.GetAttacks()[0];

            // Set pet id
            item.AddItemOption(new Models.Shop.ShopItemOption(ShopItemsHelper.PET_ID, pet.Id));

            var itemBack = Repositories.ServicesRepository.ShopService.PurchaseItem(item);
            return itemBack != null;
            
        }

        /// <summary>
        /// Buys a food and appends to the Player.
        /// </summary>
        /// <returns></returns>
        public bool PurchaseRandomFood()
        {
            var food = Constants.Shop.ShopItems.GetFood()[0];
            var itemBack = Repositories.ServicesRepository.ShopService.PurchaseItem(food);
            return itemBack != null;
        }
    }
}
