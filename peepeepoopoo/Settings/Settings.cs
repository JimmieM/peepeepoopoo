using System;
using Microsoft.Extensions.Configuration;

namespace peepeepoopoo.Settings
{

    public enum Environment
    {
        PRODUCTION, DEVELOP, TEST
    }

    public enum DataService
    {
        MOCKED, SQLSERVER, MYSQL
    }
   
    public class Settings
    {
        public IConfigurationRoot Configuration { get; set; }

        public static Environment ENVIRONMENT = Environment.DEVELOP;
        public static DataService DATASERVICE = DataService.MOCKED;
    }
}
