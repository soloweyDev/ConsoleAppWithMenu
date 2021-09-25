using System;

namespace ConsoleAppWithMenu
{
    public class Body : IWrite
    {
        public void Write(string text)
        {
            Console.SetCursorPosition(0, 2);
            Console.WriteLine(text);
        }
    }
}
