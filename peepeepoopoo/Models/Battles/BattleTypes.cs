using peepeepoopoo.Interfaces.Battles;
namespace peepeepoopoo.Models.Battles
{
    public class PVP : IBattleType
    {
        string IBattleType.Type { get =>  "PVP"; }
    }

    public class PVE : IBattleType
    {

        string IBattleType.Type { get => "PVE"; }
    }
}
