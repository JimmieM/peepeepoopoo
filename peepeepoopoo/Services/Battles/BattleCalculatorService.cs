using System;
using System.Linq;
using peepeepoopoo.Models.Battles;
using peepeepoopoo.Models.Pets;
using peepeepoopoo.Models.Pets.Creatures;

namespace peepeepoopoo.Services.Battles
{
    public class BattleCalculatorService
    {
        private int PROCC_PERCENT_CHANCE = 30;
        private int DODGE_PERCENT_CHANCE = 24;

        private Battle Battle;
        public BattleCalculatorService()
        {
            Battle = Repositories.CurrentBattleRepository.Battle;
        }

        public bool ProccOrNot(CreatureAttack attack)
        {

            return new Random().Next(1, 100) < PROCC_PERCENT_CHANCE + attack.ProccPerBattlePercentage;
        }

       
        public bool EnemyDodgesAttack(CreatureAttack attack, Pet dealer, Pet reciever)
        {
            var extraDodgePower = (reciever.Happiness.Value + reciever.Energy.Value) - dealer.Energy.Value / 3;
            return new Random().Next(1, 100) < DODGE_PERCENT_CHANCE + extraDodgePower;
        }

        /// <summary>
        /// Given that {attack} already contains full data
        /// 
        /// </summary>
        /// <param name="attack"></param>
        /// <param name="dealer"></param>
        /// <param name="reciever"></param>
        public int CalculateAttackDamage(CreatureAttack attack, Pet dealer, Pet reciever)
        {
            // Calculate how much this attack deals to the Reciever.

            var extraDamage = dealer.Strength.Value / dealer.Agility.Value / dealer.Energy.Value;

            if (reciever.Energy.StatIsAboveAverage()) {
                extraDamage -= reciever.Health.Value / 4;
            }

            // Damage only has the base damage.
            return attack.Damage + extraDamage;
        }

        /// <summary>
        /// Returns the Pet that won the battle.
        /// </summary>
        public Pet SelectWinner()
        {
            var pet1 = Battle.FirstPet;
            var pet2 = Battle.SecondPet;
            Battle.WinnerPet = pet1;
            return Battle.WinnerPet;
        }
    }
}
