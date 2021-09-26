using System;

namespace ConsoleAppWithMenu
{
    public class Top : IWrite
    {
        readonly string[] _text;

        public Top(string[] text)
        {
            _text = text;
        }

        public void Write()
        {
            foreach (string line in _text)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write(line);
            }
        }
    }
}
