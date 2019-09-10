using System;
using System.Collections.Generic;
using peepeepoopoo.Interfaces.Pets;
using peepeepoopoo.Mocked;
using peepeepoopoo.Models.Pets;

namespace peepeepoopoo.Controllers.Mocked.Players
{
    public class MockedGetMyPetsController : MockedController
    {
        public List<Pet> GetMyPets()
        {
            return Repositories.ServicesRepository.PetService.GetMyPets();
        }
    }
}
