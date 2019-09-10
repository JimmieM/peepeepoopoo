using System;
using PeepeepoopooConsoleGame.Models;

namespace PeepeepoopooConsoleGame.Story.Intro
{
    public class Intro : StoryLine
    {
        public Intro()
        {
        }

        public override StoryType StoryType { get => StoryType.InOutPut; }

        public override void Input(string input)
        {
            throw new NotImplementedException();
        }

        public override int InputRepeater(string input)
        {
            throw new NotImplementedException();
        }

        public override string PrintSequence(bool readLine = false)
        {
            return "";
        }
    }
}
