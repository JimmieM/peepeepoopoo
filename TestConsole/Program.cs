using System;
using peepeepoopoo.Controllers.Mocked;

namespace TestConsole
{
    class Program
    {
        static MockedLoginController LoginController = new MockedLoginController();
        static MockedRegisterController RegisterController = new MockedRegisterController();
        static MockedGetMyPetsController GetMyPetsController = new MockedGetMyPetsController();
        static MockedGetMyAchievementsController GetMyAchievementsController = new MockedGetMyAchievementsController();

        /// <summary>
        /// Sequence of use-case
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var login = LoginController.Login();
            var register = RegisterController.Register();


            var getAchievements = GetMyAchievementsController.GetAchievements();
            var getPets = GetMyPetsController.GetMyPets();
            
        }
    }
}
