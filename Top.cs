using System;

namespace ConsoleAppWithMenu
{
    public class Top : IWrite
    {
        public void Write(string text)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(text);
        }
    }
}
