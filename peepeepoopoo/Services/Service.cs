using System;
using System.Data.SqlClient;
using peepeepoopoo.Models.Player;
using peepeepoopoo.Settings.Database;

namespace peepeepoopoo.Services
{
    public class Service
    {
        private Database Database;
        protected SqlConnectionStringBuilder Connection;

        // Defines the Player/User
        protected Player Player;

        public Service(int userId)
        {
            Database = new Database();
            Connection = Database.GetConnection();

            RegisterPlayer(userId);
        }

        public void RegisterPlayer(int userId)
        {
            //Player = new Pl
        }
    }
}
