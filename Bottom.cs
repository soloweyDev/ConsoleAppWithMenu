using System;

namespace ConsoleAppWithMenu
{
    public class Bottom : IWrite
    {
        private int _position = 0;
        readonly string[] _text;

        public Bottom(string[] text)
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
            int linght = 0;
            foreach (string line in _text)
            {
                linght += line.Length;
            }

            int step = (99 - linght) / (_text.Length - 1);
            int position = 0;
            for (int i = 0; i < _text.Length; ++i)
            {
                Console.SetCursorPosition(position, 29);
                Console.Write(_text[i].ToUpper());
                position += _text[i].Length + step;
            }
        }
    }
}
