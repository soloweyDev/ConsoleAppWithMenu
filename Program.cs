using System;

namespace ConsoleAppWithMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Top top = new Top();
            Bottom bottom = new Bottom();
            Body body = new Body();

            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(100, 30);
            Console.SetBufferSize(100, 30);
            Console.CursorVisible = false;

            while (true)
            {
                Console.Clear();
                top.Write("Top element");
                bottom.Write("Bottom element");
                string text = "1 string\n2 string\n3 string";
                body.Write(text);

                System.Threading.Thread.Sleep(5000);
            }
        }
    }
}
