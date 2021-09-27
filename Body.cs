using System;

namespace ConsoleAppWithMenu
{
    public class Body : IWrite
    {
        private int _position = 0;
        readonly string[] _text;

        public Body(string[] text)
        {
            _text = text;
        }

        public void Next()
        {
            _position += 1;
            if (_position == _text.Length)
            {
                _position = 0;
            }
        }

        public void Previous()
        {
            --_position;
            if (_position < 0)
            {
                _position = _text.Length - 1;
            }
        }

        public void Write()
        {
            int numLine = 2;
            foreach (string line in _text)
            {
                if(numLine == _position + 2)
                {
                    Console.SetCursorPosition(0, numLine);
                    Console.Write("*");
                }
                else
                {
                    Console.SetCursorPosition(0, numLine);
                    Console.Write(" ");
                }

                Console.SetCursorPosition(2, numLine);
                Console.WriteLine(line);
                ++numLine;
            }
        }
    }
}
