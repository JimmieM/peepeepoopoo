using System;
namespace peepeepoopoo.Controllers
{
    public class MockedController
    {
        protected int USER_ID = 1;
        public MockedController()
        {
            Repositories.ServicesRepository.Initiate(USER_ID);
        }
    }
}
