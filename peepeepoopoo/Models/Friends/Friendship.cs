using System;
using System.Collections.Generic;
using peepeepoopoo.Models.Player;
namespace peepeepoopoo.Models.Friends
{
    public class Friendship
    {
        public int Id;
        public DateTime FriendshipSince;
        private List<Friend> Relations;

        public Friendship() { }

        public Friendship(int id, DateTime friendshipSince, List<Friend> relations)
        {
            Id = id;
            FriendshipSince = friendshipSince;
            Relations = relations;
        }
    }
}
