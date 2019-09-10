using System;
namespace PeepeepoopooConsoleGame.Models
{
    public enum StoryType
    {
        Input, Output, InOutPut,
    }

    public abstract class StoryLine
    {
        abstract public StoryType StoryType { get; }

        abstract public void Input(string input);

        /// <summary>
        /// Input Reapter
        /// </summary>
        /// <param name="input"></param>
        /// <returns>the reapter counter</returns>
        abstract public int InputRepeater(string input);

        abstract public string PrintSequence(bool readLine = false);


    }
}
