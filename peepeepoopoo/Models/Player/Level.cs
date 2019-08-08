using System;
namespace peepeepoopoo.Models.Player
{
    public class Level
    {
        public int CurrentLevel;
        public int CurrentExperience;
        public int ExperienceRange;

        public Level(int currentLevel, int currentExperience, int experienceRange)
        {
            CurrentLevel = currentLevel;
            CurrentExperience = currentExperience;
            ExperienceRange = experienceRange;
        }

        public Level EarnExperience(int experience)
        {
            CurrentExperience += experience;
            return new Level(CurrentLevel, CurrentExperience, ExperienceRange);
        }

        public Level Ding() {
            return new Level(0, 0, 0);
        }
    }
}
