using System;
namespace peepeepoopoo.Interfaces
{
    /// <summary>
    /// Tells a model that its parsable to JSON for storage in SQL.
    /// </summary>
    public interface IParseableModel
    {
        string ToJSON();
    }
}
