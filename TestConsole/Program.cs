using System;
using peepeepoopoo.Controllers.Mocked;
using peepeepoopoo.Controllers.Mocked.Battles;
using peepeepoopoo.Controllers.Mocked.Players;
using peepeepoopoo.Controllers.Mocked.Shop;

namespace TestConsole
{
    class Program
    {
        /**
         * Players
         */
        static MockedLoginController LoginController;
        static MockedRegisterController RegisterController;
        static MockedGetMyPetsController GetMyPetsController;
        static MockedGetMyAchievementsController GetMyAchievementsController;

        /**
         * Shop
         */
        static MockedPurchaseItemController PurchaseItemController;
        static MockedGetShopItemsController GetShopItemsController;

        /**
         * Battles
         */
        static MockedCreateBattleController CreateBattleController;
        static MockedEnterBattleController EnterBattleController;

        static void Init()
        {
            LoginController = new MockedLoginController();
            RegisterController = new MockedRegisterController();
            GetMyPetsController = new MockedGetMyPetsController();
            GetMyAchievementsController = new MockedGetMyAchievementsController();
            PurchaseItemController = new MockedPurchaseItemController();
            EnterBattleController = new MockedEnterBattleController();
            CreateBattleController = new MockedCreateBattleController();
            GetShopItemsController = new MockedGetShopItemsController();
        }

        /// <summary>
        /// Sequence of use-case
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Init();
            var login = LoginController.Login();
            var register = RegisterController.Register();


            var getAchievements = GetMyAchievementsController.GetAchievements();
            

            var pet1 = PurchaseItemController.PurchaseRandomPet("Peepeepoopoo0");
            var pet2 = PurchaseItemController.PurchaseRandomPet("Peepeepoopoo1");


            var getPets = GetMyPetsController.GetMyPets();


            if (pet1 != null && pet2 != null)
            {
                PurchaseItemController.PurchaseRandomAttack(pet1);
                PurchaseItemController.PurchaseRandomAttack(pet2);
                PurchaseItemController.PurchaseRandomAttack(pet1);
                PurchaseItemController.PurchaseRandomAttack(pet2);
            }


            var shopItems = GetShopItemsController.GetAllShopItems();
               

            var purchaseFood = PurchaseItemController.PurchaseRandomFood();

            var createBattle = CreateBattleController.CreateBattle(pet1, pet2, 30, pet1);

            var enterBattle = EnterBattleController.EnterBattle(pet1, 1);



            Console.Read();
            
        }
    }
}
