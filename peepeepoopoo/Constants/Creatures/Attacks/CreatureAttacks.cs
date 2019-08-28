using System.Collections.Generic;
using peepeepoopoo.Models.Pets.Creatures;
namespace peepeepoopoo.Constants.Creatures.Attacks
{
    public static class CreatureAttacks
    {
        
        public static List<CreatureAttack> GetAttacks()
        {
          return new List<CreatureAttack>
          {
              new CreatureAttack(1, "Bite", "", new Models.Currency.Currency(10), true, 10, 10, "", 1, "",
              new List<Models.Pets.Creature> { new Bird() }),

              new CreatureAttack(2, "Swirl", "", new Models.Currency.Currency(10), true, 10, 10, "", 1, "",
              new List<Models.Pets.Creature> { new Bird() }),

              new CreatureAttack(3, "Claw", "", new Models.Currency.Currency(10), true, 10, 10, "", 1, "",
              new List<Models.Pets.Creature> { new Bird() }),

              new CreatureAttack(4, "Feast", "", new Models.Currency.Currency(10), true, 10, 10, "", 1, "",
              new List<Models.Pets.Creature> { new Bird() }),

              new CreatureAttack(5, "Shell Protection", "", new Models.Currency.Currency(10), true, 10, 10, "", 1, "",
              new List<Models.Pets.Creature> { new Bird() }),

              new CreatureAttack(6, "Chew", "", new Models.Currency.Currency(10), true, 10, 10, "", 1, "",
              new List<Models.Pets.Creature> { new Bird() }),

              new CreatureAttack(7, "Wind Slam", "", new Models.Currency.Currency(10), true, 10, 10, "", 1, "",
              new List<Models.Pets.Creature> { new Bird() }),

              new CreatureAttack(8, "Enrage", "", new Models.Currency.Currency(10), true, 10, 10, "", 1, "",
              new List<Models.Pets.Creature> { new Bird() }),

              new CreatureAttack(9, "Tail Slam", "", new Models.Currency.Currency(10), true, 10, 10, "", 1, "",
              new List<Models.Pets.Creature> { new Bird() }),

              new CreatureAttack(10, "Rake", "", new Models.Currency.Currency(10), true, 10, 10, "", 1, "",
              new List<Models.Pets.Creature> { new Bird() }),
          };
        }
    }
}
