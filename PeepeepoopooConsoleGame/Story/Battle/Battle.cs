using System;
using PeepeepoopooConsoleGame.Models;

namespace PeepeepoopooConsoleGame.Story.Battle
{
    public class Battle : StoryLine
    {
        private peepeepoopoo.Models.Pets.Pet Pet1;
        private peepeepoopoo.Models.Pets.Pet Pet2;
        public Battle(peepeepoopoo.Models.Pets.Pet pet1, peepeepoopoo.Models.Pets.Pet pet2)
        {
            Pet1 = pet1;
            Pet2 = pet2;
        }

        public override StoryType StoryType => throw new NotImplementedException();

        public override void Input(string input)
        {
            // pet 1 attack inputs.
        }

        public override int InputRepeater(Action action, string input)
        {
            var num = Convert.ToInt32(input);

            if(num >= 1 && num <= 5)
            {
                action();
            }
        }

        public override string PrintSequence(bool readLine = false)
        {
            return "Pick an attack 1-5";
        }
    }
}
