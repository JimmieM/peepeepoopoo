using System.Collections.Generic;

namespace peepeepoopoo.Constants.Creatures.Food
{
    public static class FoodTypes
    {
        public static List<Models.Pets.Food.Food> GetFoodTypes()
        {
            return new List<Models.Pets.Food.Food>
            {
                new Models.Pets.Food.Food(1, "Carrot", 20, 20, 20, 20),
                new Models.Pets.Food.Food(2, "Cooked Chicken", 20, 20, 20, 20)
            };
        }
    }
}
