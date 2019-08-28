using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace peepeepoopoo.Settings.Database
{
    public class MySQL : Database
    {
        private MySqlConnection connection;
        private MySqlConnection Connection
        {
            get { return connection; }
        }

        private static MySQL _instance;

        public static MySQL Instance()
        {
            if (_instance == null)
                _instance = new MySQL();
            return _instance;
        }

        override public bool Connect()
        {
            if (Connection == null)
            {
                if (string.IsNullOrEmpty(DATABASE_NAME))
                    return false;

                string connstring = string.Format("Server=localhost; database={0}; UID={1}; password={2}", DATABASE_NAME, UID, PASSWORD);
                connection = new MySqlConnection(connstring);
                connection.Open();
            }

            return true;
        }

        override public void Close()
        {
            connection.Close();
        }
    }
}