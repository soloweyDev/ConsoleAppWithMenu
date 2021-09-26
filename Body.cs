using System;

namespace ConsoleAppWithMenu
{
    public class Body : IWrite
    {
        private int _position = 2;
        readonly string[] _text;

        public Body(string[] text)
        {
            _text = text;
        }

        public void Next()
        {
            ++_position;
            if (_position == _text.Length)
            {
                _position = 2;
            }
        }

        public void Previous()
        {
            --_position;
            if (_position < 2)
            {
                _position = _text.Length - 1;
            }
        }

        public void Write()
        {
            int numLine = 2;
            foreach (string line in _text)
            {
                if(numLine == _position)
                {
                    Console.SetCursorPosition(0, numLine);
                    Console.Write("*");
                }

                Console.SetCursorPosition(2, numLine);
                Console.WriteLine(line);
                ++numLine;
            }
        }
    }
}
