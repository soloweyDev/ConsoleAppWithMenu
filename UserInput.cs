using System;

namespace ConsoleAppWithMenu
{
    public class UserInput
    {
        public void WaitInput(Body body, Bottom bottom)
        {
            ConsoleKeyInfo key;
            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    bottom.Previous();
                    break;
                case ConsoleKey.RightArrow:
                    bottom.Next();
                    break;
                case ConsoleKey.UpArrow:
                    body.Previous();
                    break;
                case ConsoleKey.DownArrow:
                    body.Next();
                    break;
                default:
                    break;
            }
        }
    }
}
