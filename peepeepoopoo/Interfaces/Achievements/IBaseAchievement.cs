using System;
namespace peepeepoopoo.Interfaces.Achievements
{
    public interface IBaseAchievement
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        int Value { get; set; }
    }
}
