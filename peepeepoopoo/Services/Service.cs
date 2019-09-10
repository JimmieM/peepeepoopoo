using System;
using peepeepoopoo.Interfaces;
using peepeepoopoo.Models.Player;
using peepeepoopoo.Repositories;

using peepeepoopoo.Settings.Database;

namespace peepeepoopoo.Services
{
    public class Service : IBaseService
    {

        protected Database Db;

        // Defines the Player/User
        protected Player Player;

        public Service(int userId)
        {
            Db = new Database();

            PlayerRepository.SetPlayer(ServicesRepository.PlayerService.GetProfile(userId));
        }

        public Player GetRequesteePlayer()
        {
            throw new NotImplementedException();
        }

        public void SetRequesteePlayer(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
