using peepeepoopoo.Constants.Creatures.Food;
using peepeepoopoo.Interfaces.Pets.Creatures;
using System.Collections.Generic;

namespace peepeepoopoo.Models.Pets.Creatures
{
    public class Bird : Creature, ICreature
    {
        int ICreature.Stages => 3;

        public List<Food.Food> PrefferedFood => FoodTypes.GetFoodTypes() ;

        public Bird() 
        {
            ShopItemId = 1;
            Price = new Currency.Currency(200);
        }
    }
}
