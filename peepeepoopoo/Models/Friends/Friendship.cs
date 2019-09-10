using System;
using System.Collections.Generic;

namespace peepeepoopoo.Models.Friends
{
    public class Friendship : Parsable
    {
        public int Id;
        public DateTime FriendshipSince;
        private List<Friend> Relations;

        public bool AddRelation(Player.Player player)
        {
            if (Relations == null) Relations = new List<Friend>();
            if(Relations.Count < 2) {
                var friend = new Friend(player, true);
                Relations.Add(friend);
                return true;
            }
            return false;  
        }

        /// <summary>
        /// New friendship with init player and Friendship Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="player"></param>
        public Friendship(int id, Player.Player player) {
            Id = id;
            Relations = new List<Friend>();
            AddRelation(player);
        }

        /// <summary>
        /// New fresh friendship
        /// </summary>
        public Friendship() {
            Relations = new List<Friend>();
        }

        /// <summary>
        /// Create a Friendship that already exist
        /// </summary>
        /// <param name="id"></param>
        /// <param name="friendshipSince"></param>
        /// <param name="relations"></param>
        public Friendship(int id, DateTime friendshipSince, List<Friend> relations)
        {
            Id = id;
            FriendshipSince = friendshipSince;
            Relations = relations;
        }
    }
}
