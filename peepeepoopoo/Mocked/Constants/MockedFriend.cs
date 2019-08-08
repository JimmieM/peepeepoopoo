using System;
using peepeepoopoo.Models.Friends;
using peepeepoopoo.Models.Player;

namespace peepeepoopoo.Mocked.Constants
{
    public class MockedFriend : MockedBase
    {
        /// <summary>
        /// Player1 will be the Primary Friend in Friendship
        /// </summary>
        /// <param name="player1"></param>
        /// <param name="player2"></param>
        public static Friendship CreateFriendship(Player player1, Player player2)
        {
            var id = GenerateId();
            var newFriendship = new Friendship(id, player1);
            newFriendship.AddRelation(player1);
            newFriendship.AddRelation(player2);

            return newFriendship;
        }
    }
}
