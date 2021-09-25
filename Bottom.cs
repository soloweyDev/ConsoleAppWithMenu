using System;

namespace ConsoleAppWithMenu
{
    public class Bottom : IWrite
    {
        public void Write(string text)
        {
            Console.SetCursorPosition(0, 29);
            Console.Write(text);
        }
    }
}
