using System;
using System.Data.SqlClient;

namespace peepeepoopoo.Settings.Database
{
    public class Database
    {
        public Database()
        {
        }

        public SqlConnectionStringBuilder GetConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "anonyflow.database.windows.net";
            builder.UserID = "";
            builder.Password = "";
            builder.InitialCatalog = "anonyflow";

            return builder;
        }
    }
}
