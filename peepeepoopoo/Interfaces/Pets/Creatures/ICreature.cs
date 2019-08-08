using System.Collections.Generic;
using peepeepoopoo.Models.Pets.Food;

namespace peepeepoopoo.Interfaces.Pets.Creatures
{
    public interface ICreature
    {
        int Stages { get; }
        List<Food> PrefferedFood { get; }
    }
}
