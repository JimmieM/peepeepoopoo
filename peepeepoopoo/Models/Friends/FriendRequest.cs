using System;
using System.Collections.Generic;
using peepeepoopoo.Models.Player;
namespace peepeepoopoo.Models.Friends
{
    public class FriendRequest : Friend
    {
        readonly int Id;
        public Player.Player PlayerRequester;

        public Player.Player Player;

        /// <summary>
        /// Defines the Player, as the person that initated the friendship. The one who sees "Pending".
        /// </summary>
        public bool Primary;
        public FriendRequest(int id, Player.Player playerRequester, Player.Player player) : base(playerRequester, true)
        {
            Id = id;
            PlayerRequester = playerRequester;
            Player = player;
        }

        public Friendship AcceptFriendRequest(Player.Player player) 
        {
            if (!player.Id.Equals(Player.Id))
                return null;
            var friendsCollection = new List<Friend>();
            friendsCollection.Add(new Friend(PlayerRequester, true));
            friendsCollection.Add(new Friend(Player, false));
            return new Friendship(Id, DateTime.Now, friendsCollection);
        }
    }
}