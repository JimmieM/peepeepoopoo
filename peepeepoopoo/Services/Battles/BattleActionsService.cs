using System;
using peepeepoopoo.Models.Battles;
using peepeepoopoo.Models.Pets;
using peepeepoopoo.Models.Pets.Creatures;

namespace peepeepoopoo.Services.Battles
{
    /// <summary>
    /// Class works given that CurrentBattleRepository has been initated by BattlesServices.
    /// </summary>
    public class BattleActionsService
    {
        private BattleCalculatorService CalculatorService;

        /// <summary>
        /// Usage of Battle.FirstPet/SecondPet
        /// </summary>
        private Pet DamageDealer;

        /// 
        /// </summary>
        /// <param name="battle">The battle</param>
        /// <param name="petDealer">the pet that are supposed to deal the actions</param>
        public BattleActionsService(Pet dmgDealer)
        {
            DamageDealer = dmgDealer;

            CalculatorService = new BattleCalculatorService();

            // Assign the enemy of the battle.
            if (Repositories.CurrentBattleRepository.Battle.FirstPet.Id == dmgDealer.Id)
                Enemy = Repositories.CurrentBattleRepository.Battle.SecondPet;
            Enemy = Repositories.CurrentBattleRepository.Battle.FirstPet;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="attack"></param>
        /// <param name="extraAttackAvailable">Returns a callback bool whether or not a procc is available.</param>
        public void Attack(CreatureAttack attack, Action<bool> extraAttackAvailable)
        {

            var procc = CalculatorService.ProccOrNot(attack);

            var enemyDodges = CalculatorService.EnemyDodgesAttack(attack, DamageDealer, Enemy);
            if(enemyDodges)
            {
                return;
            }

            Enemy.Health.Value -= CalculatorService.CalculateAttackDamage(attack, DamageDealer, Enemy);

            extraAttackAvailable(procc);
        }
    }
}
