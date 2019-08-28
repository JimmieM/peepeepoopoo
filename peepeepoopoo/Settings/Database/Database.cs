using System;

namespace peepeepoopoo.Settings.Database
{
    public class Database
    {
        public string DATABASE_NAME = "peepeepoopoo";
        public string PASSWORD = "root";
        public string UID = "root";

        virtual public bool Connect()
        {
            throw new NotImplementedException("Connect is not implemented!");
        }

        virtual public void Close()
        {
            throw new NotImplementedException("Close is not implemented!");
        }

        virtual public object Query(string query)
        {
            throw new NotImplementedException("Query is not implemented!");
        }
    }
}
