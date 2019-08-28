using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Pets;
using peepeepoopoo.Mocked;
using peepeepoopoo.Models.Pets;

namespace peepeepoopoo.Controllers.Mocked.Players
{
    public class MockedGetMyPetsController : MockedController
    {
        private IPetsService PetsService;
        public MockedGetMyPetsController()
        {
            PetsService = new MockedPetsService(USER_ID);
        }

        public List<Pet> GetMyPets()
        {
            return PetsService.GetMyPets();
        }
    }
}
