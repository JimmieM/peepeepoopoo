using System;
namespace peepeepoopoo.Models.Player
{
    public class Level : Parsable
    {
        public int CurrentLevel;
        public int CurrentExperience;
        public int ExperienceRange;

        public static Level ConcreteStarterLevel()
        {
            return new Level(0, 200, 2000);
        }

        public Level(int currentLevel, int currentExperience, int experienceRange)
        {
            CurrentLevel = currentLevel;
            CurrentExperience = currentExperience;
            ExperienceRange = experienceRange;
        }

        public Level EarnExperience(int experience)
        {
            CurrentExperience += experience;
            if(CurrentExperience >= ExperienceRange)
            {
                CurrentLevel += 1;
            }
            return new Level(CurrentLevel, CurrentExperience, ExperienceRange);
        }

        public Level Ding() {
            return new Level(0, 0, 0);
        }
    }
}
