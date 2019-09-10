using System;
using System.Collections.Generic;
using PeepeepoopooConsoleGame.Models;
using PeepeepoopooConsoleGame.Story.Intro;

namespace PeepeepoopooConsoleGame
{
    class Program
    {
        private static List<StoryLine> Stories = new List<StoryLine>
        {
            new Intro(),
        };
        static void Main(string[] args)
        {
            foreach(var Story in Stories)
            {
                
            }
        }
    }
}
