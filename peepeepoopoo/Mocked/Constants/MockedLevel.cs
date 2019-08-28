using System;
using peepeepoopoo.Models.Player;

namespace peepeepoopoo.Mocked.Constants
{
    public class MockedLevel : MockedBase
    {
        public static Level CreateConcreteLevel()
        {
            return Level.ConcreteStarterLevel();
        }
    }
}
