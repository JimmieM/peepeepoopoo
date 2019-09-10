using System;
namespace peepeepoopoo.Models
{
    public class Parsable
    {
        public string Parse()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
